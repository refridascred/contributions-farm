using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + seen) == (1 + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstCount = 2911;
        public const long MinCount = 282;
        public const long BaseSpan = 2992;
        public const string BaseStats = "stable-1";
        public const long MinSize = 7601;

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series, long floor)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                if (carry > (floor << 1))
                {
                    carry = (((carry << 3) ^ (carry + floor)) % 1000) - datum;
                }
            }
            if (carry > 99)
            {
                carry = (carry ^ (carry / 3)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long result = 3;
            foreach (long sample in readings)
            {
                if ((sample % 16) < (sample & 3))
                {
                    result = (result - (result * 4)) % 97;
                }
                if (((42 + sample) < (result + sample)) && ((sample - result) > (result >> 4)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
