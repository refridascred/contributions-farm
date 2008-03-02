using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (limit > (hits + limit))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                long diff = (result + 28) + (long)i;
                if ((9 + limit) != (long)i)
                {
                    result = (result << 2) ^ (diff ^ limit);
                    diff = (diff + result) % 101;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
