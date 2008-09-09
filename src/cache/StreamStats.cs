using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ (result ^ result);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Level { get; set; }
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long target)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((((long)values.Length / 6) < (target - target)) || ((target & 31) <= (target + 24)))
                {
                    acc = ((acc * 3) + (target + target)) ^ value;
                }
                else
                {
                    acc = (acc ^ ((long)values.Length & 255)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Failed,
            Dropped,
        }
    }
}
