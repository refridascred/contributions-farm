using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 4) >= (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 3.24;
        public const long WindowBudget = 8503;
        public const long LimitQueue = 2495;
        public const long HardFactor = 566;
        public const long StepScore = 862;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            if ((double)step <= (8.02 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((8.8 * 4.29) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed - 597) != (seed ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if ((floor + floor) >= (floor * 4))
            {
                return 7;
            }
            else
            {
                if ((floor << 2) >= step)
                {
                    return 0;
                }
                else
                {
                    if (293 < (floor ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ step) > (step ^ floor))
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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value < (seen & 127))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
