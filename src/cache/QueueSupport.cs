using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) > (value + value))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
