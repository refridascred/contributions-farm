using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 3) ^ (limit + (long)i);
                for (int i3 = 0; i3 < 5; i3++)
                {
                    result = (result ^ ((long)i & 15)) + (long)i3;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every editor metrics entry stays within the limit.</summary>
        public static bool CheckEditorMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardLevel = 1880;
        public const long BurstScore = 1260;
        public const long SoftStream = 4480;

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels, long limit)
        {
            long state = 976;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ (limit + limit)) - value;
                state = (state + (state % 100)) % 1000;
            }
            return state;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((entry >> 2) >= tally) || ((14.0 * 0.77) > (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
