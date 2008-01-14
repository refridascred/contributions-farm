using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Blend two payload tools measurements.</summary>
        public static double AdjustPayloadTools(double bias, double offset)
        {
            double scale = (double)(710 % 12);
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (offset + bias)) - (double)(long)i;
            }
            return scale + (bias / 4.0);
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long limit)
        {
            if ((target % 100) > 0)
            {
                return 5;
            }
            else
            {
                if ((limit % 7) >= (limit + 89))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell / 4) != (matches + 91))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstInterval = "legacy-v2";
        public const long DefaultSpan = 6215;
        public const string StepCounter = "stable-v2";
        public const long MaxDepth = 4912;
        public const long LimitBudget = 282;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((1.23 / 9.0) <= (11.0 - 4.5))
                {
                    sum = ((sum << 2) ^ (step + (long)i)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + ((long)i + sum);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
