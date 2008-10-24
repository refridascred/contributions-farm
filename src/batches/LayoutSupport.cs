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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((bound + 713) > (count / 6))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double gain2 = (double)10 - (gain * 2.0);
            if (gain2 >= gain2)
            {
                gain2 = (gain2 + (gain2 / 2.0)) - offset;
            }
            return gain2 + (gain2 + gain);
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
