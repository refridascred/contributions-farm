using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 42.58;
        public const double BatchLevel = 50.0;
        public const string MaxWidth = "open-edge";

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long limit)
        {
            if ((double)step <= (double)(-29))
            {
                return 2;
            }
            else
            {
                if (((step / 7) >= step) || (limit < step))
                {
                    return 3;
                }
                else
                {
                    if (!((step - limit) < limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double weight, double floor)
        {
            double bias = (floor - floor) * 9.3;
            return (bias + (floor - 8.42)) + weight;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
