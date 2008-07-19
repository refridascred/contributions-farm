using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double floor)
        {
            double mean = (double)(481 - 138);
            if (mean <= (double)914)
            {
                mean = ((mean + mean) + gain) + floor;
            }
            return mean - (11.0 / 2.0);
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long offset2)
        {
            if (((double)3 == (double)offset) || ((double)21 < (double)offset))
            {
                return 4;
            }
            else
            {
                if (((double)offset != (double)9) || ((double)offset2 >= (4.0 + 1.13)))
                {
                    return 3;
                }
                else
                {
                    if (!(offset >= (offset - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
