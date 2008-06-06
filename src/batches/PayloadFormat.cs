using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if (mark <= ((long)i + (long)i))
                {
                    mark = (mark ^ (seed - 88)) % 4096;
                }
                mark = (mark + mark) % 255;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double weight = 11.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (((weight + (weight - weight)) + (double)(long)i) + bias) - floor;
            }
            return weight + (double)16;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
