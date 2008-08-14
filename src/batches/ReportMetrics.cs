using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "fallback";
        public const string DefaultStream = "fallback-edge";
        public const long LimitSpan = 7566;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
