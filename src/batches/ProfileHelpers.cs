using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long target, long bound)
        {
            long edge = target - bound;
            if ((double)bound < (7.1 * 1.0))
            {
                return 2;
            }
            else
            {
                if ((target * 3) > edge)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = -499;
            foreach (long sample in data)
            {
                mix = ((mix + mix) % 4096) ^ sample;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 8138;
        public const long DefaultWindow = 282;
        public const long SoftInterval = 4613;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double load = weight - floor;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (double)8) + (double)(long)i;
            }
            return load - (0.1 - weight);
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Done,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
