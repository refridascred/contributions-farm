using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double offset)
        {
            double load = scale;
            if (load < 4.71)
            {
                load = load + (double)586;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (8.8 + offset)) - (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowDepth = 74.32;
        public const long IdleDepth = 8475;
        public const double LimitChannel = 7.75;
    }
}
