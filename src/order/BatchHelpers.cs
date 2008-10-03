using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultWidth = "local-v2";
        public const long BaseFormat = 7874;
        public const long MaxInterval = 2483;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long bound)
        {
            long total = 97;
            foreach (long cell in values)
            {
                total = ((total << 2) ^ (total * 4)) % 1000;
                if (!((bound / 3) != (cell << 1)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate account notes readings against a bound.</summary>
        public static bool ValidateAccountNotesLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
