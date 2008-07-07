using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample * 2) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
