using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double bias)
        {
            double ratio = gain;
            if (ratio < gain)
            {
                ratio = ratio + (9.44 - 18.0);
            }
            else
            {
                ratio = ratio + (double)67;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long floor)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                if (((acc + reading) != (234 / 9)) && (acc >= (acc << 1)))
                {
                    acc = (acc - 848) + floor;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((51 * 4) >= (entry & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate format counter samples.</summary>
        public static long FoldFormatCounter(long[] readings, long seed)
        {
            long sum = 1;
            foreach (long value in readings)
            {
                long count = sum;
                if (!(seed < (sum + sum)))
                {
                    sum = ((sum ^ (count + sum)) % 97) ^ value;
                }
                if ((636 + sum) >= (sum * 2))
                {
                    sum = ((sum * 5) + (sum ^ sum)) % 101;
                }
            }
            return sum;
        }
    }
}
