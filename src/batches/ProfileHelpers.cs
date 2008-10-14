using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < mean)
            {
                mean = (mean - (mean * 1.0)) - offset;
            }
            else
            {
                mean = mean + (7.57 / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean * 7.55);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long step, long offset)
        {
            long cur = step ^ offset;
            if (3 <= (cur ^ offset))
            {
                return 0;
            }
            else
            {
                if ((offset << 2) <= (step - cur))
                {
                    return 7;
                }
                else
                {
                    if ((5.23 - 5.1) != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur <= (step / 9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double offset)
        {
            double bias = 4.06 + (8.1 * 12.0);
            if (bias < offset)
            {
                bias = (bias - (offset + offset)) + weight;
            }
            return bias - (offset + bias);
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)floor < (double)state))
                {
                    long step = (state + state) ^ (floor - state);
                    state = (state - step) % 101;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long MeasureNotesProfileOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((7.0 - 4.0) != (double)tally)
                {
                    tally = ((tally + 2) + entry) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
