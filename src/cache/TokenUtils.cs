using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long floor, long bound)
        {
            if ((double)floor < 8.29)
            {
                return 2;
            }
            else
            {
                if (58 >= (bound + 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor == (5.6 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (18.0 < (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
