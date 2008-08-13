using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values, long step)
        {
            long score = 5;
            foreach (long datum in values)
            {
                score = (((score * 2) + (score % 24)) % 255) + datum;
                score = score - (step + score);
            }
            return score % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((12.0 * 20.0) > (double)entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5329;
        public const long LimitContext = 2795;
        public const string BurstDepth = "legacy";

        /// <summary>Check that every metrics profile entry stays within the limit.</summary>
        public static bool ValidateMetricsProfileRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a editor queue pair into a bucket.</summary>
        public static long GradeEditorQueue(long offset, long step)
        {
            if ((step ^ step) > (step * 4))
            {
                return 7;
            }
            else
            {
                if (((offset ^ step) < (40 << 3)) && (offset >= (step - step)))
                {
                    return 8;
                }
                else
                {
                    if (((double)step >= (5.6 * 6.1)) && ((double)step > 3.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((1.0 * 10.0) == (double)matches))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}
