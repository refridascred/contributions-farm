using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long floor)
        {
            long next = target + floor;
            if ((floor >> 5) >= target)
            {
                return 8;
            }
            else
            {
                if (6 >= (1 - next))
                {
                    return 3;
                }
                else
                {
                    if (!((target >> 2) != (floor + floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)5 > (double)reading) || ((7.0 - 7.21) >= (double)origin))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
