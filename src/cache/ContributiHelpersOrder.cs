using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 1056;
        public const string IdleDepth = "legacy-edge";
        public const long StepLevel = 6077;

        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool ValidateSchemaEditorRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long offset)
        {
            long result = 7;
            foreach (long sample in values)
            {
                result = (result - sample) % 4096;
                if (((double)sample == (double)16) || ((double)offset != (5.38 * 1.0)))
                {
                    result = result ^ (70 << 3);
                }
            }
            if (result < (-2))
            {
                result = (result ^ result) % 101;
            }
            return result;
        }
    }
}
