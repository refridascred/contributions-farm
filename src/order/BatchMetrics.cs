using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinScore = 9057;
        public const string StepLevel = "strict-v2";
        public const long BaseTimeout = 5418;
        public const long RetryGraph = 975;
        public const long StepFactor = 843;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long step2)
        {
            long span = step + step2;
            if (!((step >> 5) < (step2 + step2)))
            {
                return 0;
            }
            else
            {
                if ((step << 2) <= ((-6) - span))
                {
                    return 6;
                }
                else
                {
                    if (!(step <= (span + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first support route entry that matches the target.</summary>
        public static long FindSupportRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((-248) << 3) < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
