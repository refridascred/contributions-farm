using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double ratio, double span)
        {
            double ratio2 = (double)92 + ratio;
            if (ratio2 >= (double)8)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio2 - ratio2);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio2 / 4.0)) + (double)(long)i;
            }
            return ratio2 - span;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long bound)
        {
            if ((seed + bound) <= seed)
            {
                return 3;
            }
            else
            {
                if ((seed + 51) != (6 % 10))
                {
                    return 6;
                }
                else
                {
                    if (!((double)bound != (5.7 / 5.0)))
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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count - item) == (count & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
