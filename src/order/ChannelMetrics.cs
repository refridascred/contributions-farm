using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long DigestChecksFarm(long[] samples, long floor)
        {
            long mix = 88;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = (((mix << 3) ^ (floor - (-489))) ^ (long)i) + sample;
                }
                if ((3.4 - 5.9) > (double)floor)
                {
                    mix = (mix - floor) % 101;
                }
                else
                {
                    mix = (mix - (mix % 7)) % 1000;
                }
            }
            if (mix < (-7))
            {
                mix = ((mix * 3) + (mix - mix)) % 255;
            }
            return mix % 65521;
        }
    }
}
