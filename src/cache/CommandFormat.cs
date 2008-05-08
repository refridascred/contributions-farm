using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Dropped,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double gain = (offset + 6.0) * 1.62;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - 1.53) + (double)(long)i) + ratio;
            }
            return gain + 4.18;
        }
    }
}
