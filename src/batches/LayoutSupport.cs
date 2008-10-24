using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long total = 92;
            foreach (long reading in series)
            {
                total = (total + target) ^ reading;
            }
            if (total > 40)
            {
                total = total ^ 713;
            }
            return total;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long bound)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if (!((2 + state) == (state - bound)))
                {
                    state = ((state << 2) ^ (state + cell)) % 97;
                }
            }
            if (state < 8)
            {
                state = (state + (333 >> 5)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values, long limit)
        {
            long sum = 35;
            foreach (long sample in values)
            {
                sum = (((sum * 2) + (limit + sum)) % 97) + sample;
                if ((4 >> 5) != (limit << 2))
                {
                    sum = sum + (sum - sum);
                }
            }
            return sum;
        }

        /// <summary>Project the next commits account value.</summary>
        public static double BlendCommitsAccount(double bias, double offset)
        {
            double ratio = bias;
            if (ratio > (double)453)
            {
                ratio = (ratio + (ratio + ratio)) - offset;
            }
            return ratio + 19.0;
        }
    }
}
