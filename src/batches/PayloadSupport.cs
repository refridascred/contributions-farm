using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 2044;
        public const long MinWidth = 2154;
        public const double MaxStats = 25.35;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
