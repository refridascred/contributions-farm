using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)cell >= (double)count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 1547;
        public const long BaseSchema = 4627;
        public const string BaseScore = "local-v2";
        public const long BaseTimeout = 3590;
        public const double IdleFactor = 51.22;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 6;
            foreach (long sample in values)
            {
                carry = (carry - carry) % 4096;
                if ((19.0 / 7.0) == (double)sample)
                {
                    carry = (carry * 5) + (132 % 97);
                }
                else
                {
                    carry = (carry - (carry ^ carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Check that every session channel entry stays within the limit.</summary>
        public static bool VerifySessionChannelLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
