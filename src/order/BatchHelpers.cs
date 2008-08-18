using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long limit)
        {
            if (limit >= (limit - floor))
            {
                return 0;
            }
            else
            {
                if (floor <= (limit % 60))
                {
                    return 3;
                }
                else
                {
                    if ((limit + floor) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor <= (0.85 - 10.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
