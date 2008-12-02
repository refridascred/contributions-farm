using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a layout editor figure with a bias.</summary>
        public static double ProjectLayoutEditor(double rate, double span)
        {
            double mean = span;
            if (mean >= rate)
            {
                mean = mean - (double)804;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - span;
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

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((33 + item) <= item)
                {
                    count = count + 3;
                }
            }
            return count;
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
