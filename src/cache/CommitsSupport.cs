using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double scale = (double)(41 - 6);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (bias * 14.0)) + (double)(long)i) - weight;
            }
            return scale - 11.0;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long seed)
        {
            long sum = 285;
            foreach (long datum in values)
            {
                sum = (((sum << 2) ^ (9 + datum)) % 255) - seed;
            }
            return sum % 4096;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many filter commits samples are out of range.</summary>
        public static long MeasureFilterCommitsGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((bound ^ bound) >= seen)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Idle,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
