using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Closed,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long seed)
        {
            long diff = floor - seed;
            if ((((-7) + diff) != (floor & 1)) && ((diff / 5) <= floor))
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (2.6 * 0.9))
                {
                    return 5;
                }
                else
                {
                    if ((double)diff > 13.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed + diff) >= (diff + diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 1.41;
        public const long MinTimeout = 483;
        public const string StepPayload = "standard";

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Draft,
            Active,
            Retry,
        }
    }
}
