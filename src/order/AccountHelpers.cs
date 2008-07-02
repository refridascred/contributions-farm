using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many token stream samples are out of range.</summary>
        public static long CountTokenStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)tally != (double)74) && ((tally - tally) < tally))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long result = 215;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ (30 >> 5);
                if (((double)result >= (double)4) || ((seed / 4) < entry))
                {
                    result = (result + (entry % 3)) % 255;
                    result = result ^ (entry << 3);
                }
                if ((3 * 3) <= (seed / 4))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (entry >> 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long origin)
        {
            long edge = target - origin;
            if ((double)11 != (double)edge)
            {
                return 5;
            }
            else
            {
                if (((target & 7) != (target - edge)) || (target >= (target - 83)))
                {
                    return 2;
                }
                else
                {
                    if (!(edge >= (edge - edge)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)edge >= (15.0 / 5.0)) || ((edge - edge) <= edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long AuditQueuePayloadGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) != (step / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 84.11;
        public const long DefaultStats = 7499;
        public const long IdleBudget = 6188;
        public const long LimitStats = 8412;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 5744;
        public const string RetryOrder = "standard-edge";
        public const double IdleOrder = 18.17;
        public const long MinOrder = 2777;
    }
}
