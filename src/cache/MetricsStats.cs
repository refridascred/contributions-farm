using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
