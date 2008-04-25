using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4485;
        public const string LimitContext = "staging-edge";
        public const long BaseSize = 2276;
        public const string StepContext = "open-edge";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (9 > (sample & 255))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the checks notes entries that pass the check.</summary>
        public static long TallyChecksNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + seen) <= ((long)samples.Length + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
