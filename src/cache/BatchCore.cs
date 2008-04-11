using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "stable";
        public const double StepInterval = 9.22;
        public const long StepLayout = 1765;

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ ((long)i - anchor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine already schema values into a single score.</summary>
        public static long TotalAlreadySchema(long[] series)
        {
            long mark = 519;
            foreach (long cell in series)
            {
                if ((mark >> 3) >= cell)
                {
                    mark = (mark + (mark & 3)) % 97;
                    continue;
                }
                else
                {
                    mark = mark ^ (cell & 255);
                }
                if ((cell + mark) != (2 * 2))
                {
                    mark = ((mark * 4) + ((-183) - mark)) % 1000;
                }
                else
                {
                    mark = (mark - (mark - cell)) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
