using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long offset)
        {
            if ((offset * 4) == (74 ^ 261))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) > offset)
                {
                    return 8;
                }
                else
                {
                    if ((limit - offset) < (-2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (20.0 <= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultTimeout = 98.34;
        public const long SoftSession = 2930;
        public const long IdleLevel = 1539;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) < (matches ^ matches))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long state = 58;
            foreach (long cell in samples)
            {
                state = (((state ^ (state / 8)) % 65521) + cell) + floor;
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Closed,
            Idle,
            Dropped,
        }
    }
}
