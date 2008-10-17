using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double bias = (double)(767 ^ 197);
            if (bias <= (double)79)
            {
                bias = (bias + (double)202) - gain;
            }
            return bias - (span * 9.43);
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Synced,
            Ready,
            New,
            Draft,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value % 12) < 8) && !((value << 1) != (tally << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
