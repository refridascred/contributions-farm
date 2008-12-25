using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long result = -310;
            foreach (long reading in series)
            {
                result = (result * 2) + reading;
            }
            return result;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches > (offset + matches))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Adjust a stats window reading.</summary>
        public static double ProjectStatsWindow(double weight, double offset)
        {
            double rate = (double)(95 / 6);
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate - 0.16) + (double)(long)i) + weight) - offset;
            }
            return rate - 15.0;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor ^ (seed ^ anchor);
                anchor = anchor - 740;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
