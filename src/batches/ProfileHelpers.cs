using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a tools batches value against two limits.</summary>
        public static long ClassifyToolsBatches(long step, long origin)
        {
            if ((double)step > (0.3 - 1.56))
            {
                return 3;
            }
            else
            {
                if ((step + origin) < (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((8.0 - 9.41) == (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Draft,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3809;
        public const double StepPayload = 61.9;
        public const long WindowPayload = 2987;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Retry,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up batches stats samples.</summary>
        public static long PairBatchesStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
