using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit contributi notes readings against a rule.</summary>
        public static long CountContributiNotesOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits & 127) == (reading << 2))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 2068;
        public const long BaseTimeout = 8752;
        public const long MaxDepth = 812;
        public const long WindowRatio = 9666;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long seed)
        {
            long edge = offset + seed;
            if ((seed + (-1)) > (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if ((edge << 3) < (offset + seed))
                {
                    return 5;
                }
                else
                {
                    if (((offset ^ offset) == (5 - offset)) && ((edge & 15) == (offset + seed)))
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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)origin <= (7.88 - 13.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
