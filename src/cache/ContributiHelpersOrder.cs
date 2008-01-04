using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit batches cluster readings against a rule.</summary>
        public static long CountBatchesClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((-8) <= matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double AdjustProfileContributi(double weight, double span)
        {
            double gain = (double)(-45) + (weight + weight);
            if (gain <= (gain * 3.0))
            {
                gain = (gain + (gain * 2.0)) - span;
            }
            return gain + (double)771;
        }
    }
}
