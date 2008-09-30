using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > (seen * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((state * 2) != (196 + 7)))
                {
                    state = (state - ((long)i - (long)i)) % 101;
                    state = (state << 2) ^ (state - (-24));
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long floor)
        {
            long cur = step ^ floor;
            if ((floor / 4) <= floor)
            {
                return 4;
            }
            else
            {
                if ((cur / 9) == (456 + 52))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry * 3) + 119;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
