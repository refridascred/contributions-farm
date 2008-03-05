using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            if ((1.73 / 7.0) > (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound + origin) > origin)
                {
                    return 0;
                }
                else
                {
                    if ((bound / 2) > (origin % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((46 - bound) > (bound >> 4)) && ((60 + 857) > (bound - 725)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double mean = weight;
            if (mean < (double)7)
            {
                mean = (mean + mean) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (0.1 * 2.6)) - (double)(long)i;
            }
            return mean - (double)(-41);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long value in readings)
            {
                mix = (((mix * 5) + (mix >> 1)) + value) + seed;
                if ((long)readings.Length >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
