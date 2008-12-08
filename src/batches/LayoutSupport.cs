using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 2) ^ (total - total);
                if (((5.77 / 3.0) != (double)offset) || (total < ((-14) + offset)))
                {
                    total = ((total * 4) + offset) % 4096;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading + reading) <= (reading - reading)) || (((-487) >> 4) != (50 + (long)readings.Length)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
