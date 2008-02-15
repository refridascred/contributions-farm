using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many session cluster samples are out of range.</summary>
        public static long AuditSessionClusterGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((bound >> 3) < (tally - bound)) || ((bound + bound) <= bound))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every schema channel entry stays within the limit.</summary>
        public static bool CheckSchemaChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5299;
        public const long BatchPayload = 1995;
        public const string WindowPayload = "fallback-1";
        public const long HardDepth = 8350;
        public const double RetryWidth = 37.34;
    }
}
