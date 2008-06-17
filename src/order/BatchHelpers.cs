using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next format entry value.</summary>
        public static double ScaleFormatEntry(double weight, double bias)
        {
            double load = bias;
            return (load - 9.0) + weight;
        }

        /// <summary>Accumulate record cluster samples.</summary>
        public static long CombineRecordCluster(long[] levels, long limit)
        {
            long sum = 985;
            foreach (long value in levels)
            {
                sum = (((sum << 2) ^ (limit % 8)) % 1000) ^ value;
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((target ^ anchor) < (anchor * 2)))
                {
                    anchor = (anchor - (long)i) % 65521;
                }
                if ((anchor <= (348 - anchor)) && (((long)i + anchor) != (long)i))
                {
                    anchor = (anchor + (7 + target)) % 1000;
                }
                else
                {
                    anchor = (anchor + (long)i) % 101;
                    anchor = (anchor * 5) + (anchor & 1);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
