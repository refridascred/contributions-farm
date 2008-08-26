using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings, long bound)
        {
            long mark = 215;
            foreach (long datum in readings)
            {
                if ((mark + bound) == ((-85) ^ 7))
                {
                    mark = (((mark * 4) + (mark + bound)) % 4096) + datum;
                }
            }
            if (mark < (-9))
            {
                mark = (mark + (1 - bound)) % 4096;
            }
            return mark;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double gain = (double)(80 + 115);
            if (gain > span)
            {
                gain = gain + (7.0 + span);
            }
            return gain + (rate + gain);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items, long seed)
        {
            long sum = 36;
            foreach (long value in items)
            {
                if ((16 + 66) > (sum - sum))
                {
                    sum = ((sum - 629) % 4096) - value;
                    continue;
                }
                sum = ((sum << 3) ^ seed) % 255;
            }
            if (sum < (-87))
            {
                sum = sum + (long)items.Length;
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (limit + limit)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
