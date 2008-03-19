using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 4) + target;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 3866;
        public const long HardLevel = 3072;
        public const long LimitScore = 6384;
        public const string StepSize = "alpha";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            New,
            Closed,
        }
    }
}
