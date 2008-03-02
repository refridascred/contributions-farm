using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of stream cache readings.</summary>
        public static long TallyStreamCache(long[] series)
        {
            long mix = -8;
            foreach (long reading in series)
            {
                if ((7.0 * 16.0) > (double)mix)
                {
                    mix = ((mix * 2) + reading) % 101;
                    mix = mix + ((-19) ^ mix);
                }
                if ((long)series.Length >= reading)
                {
                    mix = ((mix * 5) + (reading + reading)) % 255;
                }
                if ((reading - mix) > (mix * 4))
                {
                    mix = (mix ^ (reading % 60)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Stale,
            Retry,
            New,
            Queued,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
