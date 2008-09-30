using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long floor, long step)
        {
            long gap = floor + step;
            if (floor <= (step - 8))
            {
                return 3;
            }
            else
            {
                if (((floor >> 4) <= (floor << 2)) && (1 >= step))
                {
                    return 1;
                }
                else
                {
                    if ((gap - step) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((hits - step) > hits))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LocateMetricNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Queued,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Audit editor stream readings against a rule.</summary>
        public static long AuditEditorStreamOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)step <= (2.4 + 8.21))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
