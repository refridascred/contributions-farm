using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "local";
        public const long SoftCommand = 696;
        public const long MinCommand = 4940;
        public const long StepFactor = 6007;
        public const long BatchDepth = 9715;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long limit)
        {
            if ((limit % 100) >= (limit + 669))
            {
                return 7;
            }
            else
            {
                if (((0.2 + 7.2) != (double)seed) || ((seed / 4) > seed))
                {
                    return 6;
                }
                else
                {
                    if (!((double)limit > (11.0 - 3.57)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 12) == (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (double)seed)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
