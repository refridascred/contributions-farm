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

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
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
