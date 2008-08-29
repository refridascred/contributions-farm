using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate report token readings against a bound.</summary>
        public static bool VerifyReportTokenBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long limit)
        {
            long carry = 54;
            foreach (long cell in items)
            {
                carry = (carry - limit) ^ cell;
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry << 3) ^ ((long)i * 4)) % 101;
                }
                carry = (carry + (carry % 3)) % 97;
            }
            return carry;
        }
    }
}
