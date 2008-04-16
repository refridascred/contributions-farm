using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double load = (double)39 * 9.92;
            if (load <= 1.0)
            {
                load = load - (4.3 + load);
            }
            else
            {
                load = load - (span + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (8.4 / 9.0)) + (double)(long)i;
            }
            return load + (span / 7.0);
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
