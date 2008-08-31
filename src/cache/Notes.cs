using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (4 >= count)
                {
                    count = ((count + 2) + reading) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples, long floor)
        {
            long mark = 858;
            foreach (long datum in samples)
            {
                if ((double)floor >= (1.1 / 5.0))
                {
                    mark = ((mark + floor) % 65521) + datum;
                }
                if ((double)mark != (18.0 / 4.0))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ origin) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
