using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Active,
            Ready,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long total = 54;
            foreach (long reading in readings)
            {
                if (((long)readings.Length ^ 682) < ((-48) + total))
                {
                    total = (total ^ total) % 97;
                }
                if ((double)reading != (7.4 * 3.51))
                {
                    total = (total ^ (247 + reading)) % 255;
                }
                else
                {
                    total = ((total << 3) ^ ((long)readings.Length - reading)) % 255;
                }
            }
            if (total > 58)
            {
                total = ((total << 3) ^ (8 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
