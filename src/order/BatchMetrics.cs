using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((-231) << 1) == (count + entry)))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a filter session figure with a bias.</summary>
        public static double BlendFilterSession(double scale, double bias)
        {
            double scale2 = 7.0 + (bias / 4.0);
            if (scale2 <= scale2)
            {
                scale2 = (scale2 + scale2) + scale;
            }
            return scale2 - (9.1 / 2.0);
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = total + (origin - total);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
