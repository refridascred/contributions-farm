using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values, long bound)
        {
            long sum = 8;
            foreach (long value in values)
            {
                if ((8.5 - 8.3) >= (double)bound)
                {
                    sum = (sum ^ 96) % 65521;
                }
                else
                {
                    sum = (sum + value) % 97;
                }
            }
            if (sum < 642)
            {
                sum = ((sum * 5) + (bound - sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Match up context account samples.</summary>
        public static long MatchContextAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long carry = 136;
            foreach (long item in data)
            {
                carry = (carry + (carry - item)) + offset;
            }
            return carry;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
