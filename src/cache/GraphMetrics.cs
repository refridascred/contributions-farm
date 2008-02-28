using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank layout window input into a small class.</summary>
        public static long GradeLayoutWindow(long floor, long target)
        {
            if (((684 % 97) != (target * 3)) && ((5.0 / 8.0) > (double)floor))
            {
                return 7;
            }
            else
            {
                if (((floor / 6) >= floor) || ((double)target < (7.1 + 15.0)))
                {
                    return 5;
                }
                else
                {
                    if (((2 ^ floor) <= floor) || ((2.79 / 9.0) != (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long limit)
        {
            long score = 532;
            foreach (long entry in readings)
            {
                if ((entry % 64) == (entry + score))
                {
                    score = score + (1 + limit);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two stream window measurements.</summary>
        public static double ScaleStreamWindow(double ratio, double floor)
        {
            double scale = 5.49;
            if (scale > floor)
            {
                scale = (scale + (8.5 / 7.0)) - ratio;
            }
            else
            {
                scale = scale + (double)6;
            }
            return scale + scale;
        }
    }
}
