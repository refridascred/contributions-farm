using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double gain = (double)(608 * 5);
            if (gain > (gain + rate))
            {
                gain = (gain - (2.79 / 5.0)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (1.08 + 8.16)) + (double)(long)i;
            }
            return gain + (7.03 * 2.91);
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + count) >= (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit checks githubfarm readings against a rule.</summary>
        public static long TallyChecksGithubfarmGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count >> 3) == (datum & 7))
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
