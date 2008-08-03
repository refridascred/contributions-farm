using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(datum > ((-793) + 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine session buffer values into a single score.</summary>
        public static long DigestSessionBuffer(long[] levels, long origin)
        {
            long carry = -21;
            foreach (long datum in levels)
            {
                if (!(6.0 <= (double)carry))
                {
                    carry = (carry ^ datum) % 97;
                }
                else
                {
                    carry = (carry * 4) + 278;
                }
            }
            if (carry < (-433))
            {
                carry = carry - origin;
            }
            return carry % 97;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] samples, long floor)
        {
            long mix = 9;
            foreach (long sample in samples)
            {
                mix = (mix - (floor % 10)) + sample;
                mix = (mix - (mix + 39)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            New,
            Locked,
            Active,
        }
    }
}
