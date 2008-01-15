using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long step)
        {
            if (((floor + floor) > 530) || ((floor / 4) == (step >> 4)))
            {
                return 7;
            }
            else
            {
                if ((floor - step) <= (step + floor))
                {
                    return 3;
                }
                else
                {
                    if (((-4) + step) < step)
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
}
