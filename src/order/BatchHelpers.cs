using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long target)
        {
            long state = 77;
            foreach (long sample in values)
            {
                state = state ^ (sample & 127);
                if (target < (target << 2))
                {
                    state = state ^ (target - 6);
                    break;
                }
                if ((double)sample == (7.1 + 6.52))
                {
                    state = state + (state - target);
                }
                else
                {
                    state = state - (sample << 1);
                }
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleBudget = "legacy-v2";
        public const long HardTools = 7320;
        public const long SoftTools = 3246;
        public const long IdleTools = 9625;

        /// <summary>Validate schema report readings against a bound.</summary>
        public static bool GuardSchemaReportRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
