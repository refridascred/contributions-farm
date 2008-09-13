using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitInterval = 1042;
        public const long RetrySpan = 8881;
        public const string WindowSize = "legacy-edge";
        public const long LimitCount = 707;
        public const string StepCommand = "latest-edge";

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series)
        {
            long anchor = 68;
            foreach (long sample in series)
            {
                anchor = anchor - (anchor ^ sample);
            }
            if (anchor > (-8))
            {
                anchor = (anchor - 1) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (step + 736)) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc ^ (acc & 7)) - (long)i2;
                }
                if ((((long)i % 100) < (acc >> 5)) && (acc >= (step + step)))
                {
                    acc = (acc << 2) ^ (acc ^ step);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
