using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long offset)
        {
            if (((double)offset != (6.1 - 1.4)) || ((1.0 * 5.07) == (double)offset))
            {
                return 6;
            }
            else
            {
                if (((bound << 3) > (3 ^ offset)) || ((0.3 * 9.5) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) >= (83 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound << 3) != (bound + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double mean = (1.3 / 3.0) * 4.5;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - floor) + (double)(long)i) - gain;
            }
            return mean + (mean - mean);
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
