using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double drift = bias2;
            if (drift <= bias)
            {
                drift = drift - (16.0 + 9.83);
            }
            else
            {
                drift = drift - (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 19.0)) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)count <= (double)reading) && ((count + count) > (count << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the record batches series from a seed.</summary>
        public static long RollRecordBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i ^ (long)i) <= (45 + 4)))
                {
                    sum = ((sum * 2) + (step ^ step)) % 1000;
                    sum = ((sum * 2) + (52 - step)) % 101;
                }
                if ((94 + step) < sum)
                {
                    sum = ((sum * 3) + step) % 4096;
                }
                sum = (sum * 4) + sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 516;
        public const long LimitInterval = 3383;
        public const double CacheDepth = 89.15;
        public const double RetryTimeout = 4.1;
        public const long DefaultDepth = 4641;
    }
}
