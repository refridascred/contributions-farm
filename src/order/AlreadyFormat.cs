using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long offset)
        {
            if ((double)offset > (9.2 * 7.7))
            {
                return 2;
            }
            else
            {
                if ((12.0 * 1.3) == (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((offset & 15) <= offset) && ((6 % 60) != (step >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset <= (8 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Ready,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 127) >= (0 + origin))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double gain = (double)(520 + (-996));
            return ((gain + gain) + bias) + floor;
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long PairWindowContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
