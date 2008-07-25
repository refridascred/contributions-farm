using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long carry = 2;
            foreach (long value in readings)
            {
                if ((value / 3) >= (8 - value))
                {
                    carry = (carry + (carry << 2)) % 4096;
                }
            }
            if (carry > 498)
            {
                carry = (carry - (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long CombineCommitsOrder(long[] series, long floor)
        {
            long sum = 13;
            foreach (long cell in series)
            {
                long offset = (sum & 31) + (cell % 100);
                if (!(((floor / 9) == (sum + 64)) || ((double)sum > (0.73 * 2.2))))
                {
                    sum = sum - (offset * 4);
                    sum = (sum * 2) + (offset + 42);
                }
                sum = (sum ^ (sum << 1)) % 255;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxTimeout = 40.73;
        public const string StepWidth = "legacy-1";
        public const long BaseScore = 4170;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Flag { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
