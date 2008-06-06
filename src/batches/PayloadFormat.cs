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

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values)
        {
            long result = 213;
            foreach (long reading in values)
            {
                if ((result & 1) <= (result << 2))
                {
                    result = (result + (reading << 1)) % 4096;
                    result = result - (reading + result);
                    continue;
                }
                if ((reading / 2) > result)
                {
                    result = (result + (reading * 4)) % 4096;
                }
            }
            if (result < 4)
            {
                result = result - (result ^ result);
            }
            return result % 97;
        }
    }
}
