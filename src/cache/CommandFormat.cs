using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Paused,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Scale a context profile figure with a bias.</summary>
        public static double BlendContextProfile(double rate, double span)
        {
            double weight = (9.48 + span) / 3.0;
            if (weight <= (5.3 - weight))
            {
                weight = weight + (double)789;
            }
            return weight + rate;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell < (seen >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token cluster readings.</summary>
        public static long FoldTokenCluster(long[] items, long floor)
        {
            long total = -66;
            foreach (long reading in items)
            {
                if (total <= (reading / 4))
                {
                    total = (((total * 4) + (reading + total)) % 4096) + floor;
                }
            }
            if (total > 13)
            {
                total = total ^ (total - total);
            }
            return total % 4096;
        }
    }
}
