using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next already context value.</summary>
        public static double BlendAlreadyContext(double gain, double offset)
        {
            double rate = offset;
            if (rate <= (gain - offset))
            {
                rate = rate - (double)8;
            }
            return rate + (7.0 * 9.0);
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
