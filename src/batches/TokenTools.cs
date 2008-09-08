using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every report schema entry stays within the limit.</summary>
        public static bool VerifyReportSchemaLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
