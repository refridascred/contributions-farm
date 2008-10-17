using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultInterval = 27.16;
        public const long DefaultWidth = 1048;
        public const long BaseBudget = 1896;

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetrySize = "legacy-edge";
        public const long StepScore = 821;
        public const string MinWidth = "local-edge";
        public const long WindowEntry = 2702;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)limit >= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every record command entry stays within the limit.</summary>
        public static bool ValidateRecordCommandLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
