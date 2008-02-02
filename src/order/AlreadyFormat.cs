using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a queue already pair into a bucket.</summary>
        public static long SortQueueAlready(long origin, long offset)
        {
            if ((double)offset != (4.8 - 1.22))
            {
                return 3;
            }
            else
            {
                if (origin < (57 % 12))
                {
                    return 8;
                }
                else
                {
                    if (offset > (841 - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset <= (offset << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm commits value.</summary>
        public static double BlendGithubfarmCommits(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= floor)
            {
                ratio = ratio - (scale - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio / 9.0)) + (double)(long)i;
            }
            return ratio - (floor / 7.0);
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double SmoothNotesCluster(double gain, double floor)
        {
            double rate = floor + floor;
            if (rate > gain)
            {
                rate = rate + (double)0;
            }
            return rate - 16.0;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((10.0 < (double)seen) || (value <= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Idle,
            Done,
            Pending,
        }
    }
}
