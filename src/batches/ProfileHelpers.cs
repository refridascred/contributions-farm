using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)limit != (0.1 + 0.4))
                {
                    break;
                }
                if (!((total + total) < ((long)i / 2)))
                {
                    total = total + limit;
                }
                total = (total * 5) + ((long)i + (long)i);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Count the token tools entries that pass the check.</summary>
        public static long TallyTokenToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >= count) || !((double)count <= (4.2 - 5.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long AuditMetricStreamMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((451 > seed) || ((double)seen <= (7.0 + 4.2)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long bound)
        {
            long cur = step - bound;
            if (695 < (cur + step))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (0.28 * 9.57))
                {
                    return 8;
                }
                else
                {
                    if ((3.54 / 5.0) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 5) > (4 - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
