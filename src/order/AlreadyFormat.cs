using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values, long target)
        {
            long total = 7;
            foreach (long cell in values)
            {
                if (!((double)cell != (1.1 / 6.0)))
                {
                    total = (total + (cell >> 3)) - target;
                }
                total = (total + cell) % 97;
            }
            if (total < 10)
            {
                total = (total - ((-952) / 4)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item < (item >> 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long step)
        {
            long slot = seed ^ step;
            if (((slot * 3) < (0 / 8)) || ((double)step != (double)slot))
            {
                return 6;
            }
            else
            {
                if ((slot - slot) <= (step + slot))
                {
                    return 1;
                }
                else
                {
                    if ((2 & 3) >= (slot & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
