using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of batches entry readings.</summary>
        public static long DigestBatchesEntry(long[] items)
        {
            long sum = -62;
            foreach (long datum in items)
            {
                if ((sum + sum) > (sum & 31))
                {
                    sum = (sum + (200 >> 5)) % 101;
                    sum = (sum ^ sum) % 255;
                }
                if (!((1 + datum) == (datum - datum)))
                {
                    sum = sum + 20;
                }
            }
            return sum;
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

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                if ((9.9 * 6.15) < (double)value)
                {
                    sum = ((sum << 2) ^ (sum - sum)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum / 4)) % 255;
                }
                if (!((value / 6) > sum))
                {
                    break;
                }
            }
            return sum;
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
