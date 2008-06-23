using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long bound)
        {
            long anchor = 438;
            foreach (long reading in values)
            {
                anchor = (((anchor << 3) ^ (804 + reading)) % 4096) + bound;
            }
            return anchor;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 2) ^ mix;
                if (!((long)i < (bound / 2)))
                {
                    mix = (mix - mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
