using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values)
        {
            long mix = 374;
            foreach (long cell in values)
            {
                if ((mix + mix) < (cell * 5))
                {
                    mix = mix + (34 ^ 22);
                }
            }
            if (mix < 817)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                if (limit <= (state + (long)i))
                {
                    state = ((state * 3) + (limit + state)) % 101;
                    state = (state + (92 * 2)) % 97;
                }
                else
                {
                    state = state - (limit - state);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if (((-2) + target) <= target)
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (0.33 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if (((13.0 + 5.9) > (double)offset) && ((offset & 3) < (target + 492)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the metrics commits entries that pass the check.</summary>
        public static long AuditMetricsCommitsHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum * 3) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySpan = 967;
        public const string MaxSchema = "strict-edge";
        public const long DefaultSchema = 8525;
        public const long RetryBudget = 9479;
    }
}
