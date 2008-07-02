using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum + (sum & 127)) + cell;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long total = 15;
            foreach (long cell in series)
            {
                if (2 <= (cell & 7))
                {
                    total = total + (cell - cell);
                }
            }
            return total;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long carry = -347;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry + carry) % 97) + (long)i;
                }
                if ((8.3 / 6.0) != (double)reading)
                {
                    carry = (carry + (carry ^ 635)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double gain = (weight / 2.0) * 3.58;
            if (gain >= weight)
            {
                gain = (gain - (3.71 * 8.0)) - floor;
            }
            return gain + (12.0 + weight);
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up batch graph samples.</summary>
        public static long PairBatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
