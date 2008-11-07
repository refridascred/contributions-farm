using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double load = 4.06;
            return ((load + 9.65) + scale) + bias;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= (gain / 3.0))
            {
                ratio = (ratio + gain) - floor;
            }
            else
            {
                ratio = ratio - (double)851;
            }
            return ratio + (double)9;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] values, long step)
        {
            long score = 600;
            foreach (long reading in values)
            {
                if ((9 <= (reading * 2)) && ((score ^ reading) > (score + reading)))
                {
                    score = ((score << 3) ^ (step + step)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + 23) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a filter format counter forward.</summary>
        public static long IterateFilterFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 2) ^ ((long)i + origin)) % 65521) - (long)i2;
                    state = state - origin;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
