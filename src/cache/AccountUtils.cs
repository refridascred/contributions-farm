using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (41 & 1)) % 255;
                result = (result * 4) + (offset >> 1);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
