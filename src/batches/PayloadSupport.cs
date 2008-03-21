using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (447 < (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a queue session reading.</summary>
        public static double SmoothQueueSession(double ratio, double offset)
        {
            double load = ratio - (ratio / 8.0);
            if (load <= (double)35)
            {
                load = load - (double)0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load + (double)0;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
