using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "latest-v2";
        public const string WindowInterval = "primary";
        public const long BatchTimeout = 2572;
        public const long BatchSpan = 3945;
        public const long HardRatio = 1391;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long prev = offset - step;
            if ((step ^ offset) <= prev)
            {
                return 2;
            }
            else
            {
                if ((15.0 * 9.3) == (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((offset << 1) == (offset ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
