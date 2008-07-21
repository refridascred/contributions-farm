using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a notes filter figure with a bias.</summary>
        public static double ProjectNotesFilter(double weight, double bias)
        {
            double mean = 8.4;
            if (mean >= bias)
            {
                mean = mean + (mean * 0.81);
            }
            else
            {
                mean = mean + (double)6;
            }
            return mean + (weight - 6.0);
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((5 & 1) >= (count * 4))
                {
                    count = ((count + 3) + sample) + offset;
                }
            }
            return count;
        }
    }
}
