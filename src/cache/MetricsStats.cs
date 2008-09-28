using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double rate, double span)
        {
            double drift = (rate + span) + (double)(-1);
            if (drift <= rate)
            {
                drift = drift - (rate + rate);
            }
            else
            {
                drift = drift + rate;
            }
            return drift - (5.46 * 2.07);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 1) <= (step + step))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item <= (16.0 + 5.6)) && ((hits >> 5) < (hits % 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long limit)
        {
            if (bound < (bound & 255))
            {
                return 1;
            }
            else
            {
                if ((bound << 3) < (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    if (((limit >> 1) < (limit + (-98))) && ((limit - limit) <= (limit & 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((11.0 / 5.0) > (0.91 + 7.22))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
