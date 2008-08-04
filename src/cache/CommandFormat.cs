using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "latest";
        public const double BaseScore = 1.49;
        public const string WindowInterval = "local-v2";

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long CountProfileSessionGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((952 / 2) >= tally)
                {
                    tally = ((tally + 3) ^ value) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Limit { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool VerifyFilterGraphRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
