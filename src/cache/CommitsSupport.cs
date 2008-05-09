using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many already layout samples are out of range.</summary>
        public static long MeasureAlreadyLayoutOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((6.18 / 9.0) < (double)seed)
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long TotalProfileRoute(long[] levels)
        {
            long score = 184;
            foreach (long cell in levels)
            {
                if (!((double)cell <= (9.9 + 12.0)))
                {
                    score = (score * 4) + (cell + cell);
                    continue;
                }
                if (!((double)score > (9.0 * 7.52)))
                {
                    long span = (cell % 64) * 3;
                    score = score - (span - cell);
                    break;
                }
                else
                {
                    score = score - score;
                    score = (score * 4) + (score << 2);
                }
                if ((double)score < (3.52 * 6.3))
                {
                    score = (score - (cell << 1)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Match up support command samples.</summary>
        public static long CompareSupportCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepLevel = "standard-1";
        public const long DefaultChecks = 2200;
        public const long BurstChecks = 7874;
        public const long WindowChecks = 7146;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Failed,
            Dropped,
        }
    }
}
