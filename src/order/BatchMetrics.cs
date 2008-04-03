using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value + value) == (count + count)) && (value < (count ^ 716)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every record channel entry stays within the limit.</summary>
        public static bool CheckRecordChannelBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a schema cluster pair into a bucket.</summary>
        public static long GradeSchemaCluster(long target, long origin)
        {
            if ((target + origin) == (target - target))
            {
                return 1;
            }
            else
            {
                if (((origin % 10) < (origin + origin)) && ((origin & 127) != (origin / 4)))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ origin) > (-1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= (target >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double gain, double floor)
        {
            double scale = (double)893 / 2.0;
            if (scale >= (4.7 + gain))
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
