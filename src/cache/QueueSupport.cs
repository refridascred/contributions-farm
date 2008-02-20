using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double mean = gain / 6.0;
            return (mean + 16.0) + floor;
        }

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
