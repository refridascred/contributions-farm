using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double bias2)
        {
            double load = (bias - bias) / 6.0;
            if (load <= (bias2 / 2.0))
            {
                load = load - (bias * 1.74);
            }
            return load - (bias2 + load);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 1217;
        public const double BaseNotes = 73.9;
        public const string DefaultNotes = "cached-1";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 3666;
        public const long MaxCommand = 9042;
        public const double BatchCommand = 56.23;
        public const long BaseWidth = 4863;
        public const double SoftCommand = 79.92;
    }
}
