using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((5.1 / 5.0) > (double)datum) && ((3.5 + 9.29) != (double)floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double drift = floor;
            if (drift < (gain / 8.0))
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)4) - (double)(long)i;
            }
            return drift + (gain + 2.98);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long total = 582;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (total & 1)) % 65521) - cell;
            }
            if (total > 31)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Ready,
            Paused,
            Closed,
        }
    }
}
