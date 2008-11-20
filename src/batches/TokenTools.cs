using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally < (offset + 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long origin)
        {
            long span = bound + origin;
            if (!(span >= (span << 3)))
            {
                return 5;
            }
            else
            {
                if ((span << 3) != (origin - 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound - 936) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "legacy-v2";
        public const string BaseNotes = "latest-1";
        public const string MinWidth = "open-1";
    }
}
