using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double offset)
        {
            double gain = 7.0;
            if (gain < (double)6)
            {
                gain = (gain - (double)50) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 8.0) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count < step) && (787 < (count ^ count))) && (count < (step ^ step)))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long SortCounterReport(long floor, long bound)
        {
            if (!((floor / 8) >= (bound - 92)))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) >= (floor * 4))
                {
                    return 1;
                }
                else
                {
                    if ((0 + floor) > (89 + 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] levels, long step)
        {
            long state = 7;
            foreach (long value in levels)
            {
                state = (state - state) % 101;
                if (0.15 < (double)step)
                {
                    state = (state * 5) + (value - value);
                }
                else
                {
                    state = (state << 3) ^ (step >> 2);
                }
            }
            return state % 1000;
        }
    }
}
