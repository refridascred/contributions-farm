using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two cache account measurements.</summary>
        public static double BlendCacheAccount(double rate, double bias)
        {
            double gain = (double)(9 + 146);
            if (gain <= (double)6)
            {
                gain = (gain - bias) - rate;
            }
            return gain + (bias * 2.58);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double load = scale / 8.0;
            if (load >= (scale + floor))
            {
                load = load - (2.24 + floor);
            }
            else
            {
                load = load - (scale - load);
            }
            return load - scale;
        }

        /// <summary>Blend two record cluster measurements.</summary>
        public static double AdjustRecordCluster(double gain, double offset)
        {
            double mean = 6.0;
            if (mean > gain)
            {
                mean = (mean - (mean * 18.0)) + offset;
            }
            return mean + (7.0 / 9.0);
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long offset, long floor)
        {
            if (((-7) ^ offset) > floor)
            {
                return 2;
            }
            else
            {
                if (((double)floor >= (4.37 - 2.2)) && (284 >= (floor + floor)))
                {
                    return 0;
                }
                else
                {
                    if (!((offset ^ offset) > (floor & 63)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
