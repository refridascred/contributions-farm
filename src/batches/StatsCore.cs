using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double ratio = 0.19;
            return ((ratio + (3.0 / 2.0)) + scale) + bias;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next report entry value from a seed.</summary>
        public static long StepReportEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((double)total >= (2.7 * 7.99)) || ((double)offset >= 7.36))
                {
                    total = ((total * 2) + (total * 4)) % 1000;
                    total = ((total << 2) ^ (total + total)) % 97;
                    continue;
                }
                else
                {
                    total = (total * 2) + (offset + offset);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
