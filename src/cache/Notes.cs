using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate cluster profile samples.</summary>
        public static long TotalClusterProfile(long[] data, long seed)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                if ((anchor + anchor) < (seed ^ seed))
                {
                    anchor = (anchor - (seed % 64)) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] series, long bound)
        {
            long result = 922;
            foreach (long item in series)
            {
                if (((bound + result) != (117 * 4)) && ((double)item > (double)result))
                {
                    result = ((result << 2) ^ (508 - result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Rank graph format input into a small class.</summary>
        public static long SortGraphFormat(long origin, long floor)
        {
            long gap = origin - floor;
            if (((origin - gap) > (3 - 437)) && ((gap * 5) >= (origin - gap)))
            {
                return 5;
            }
            else
            {
                if (!((origin - 2) >= (floor - 1)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + gap) >= (origin & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)89 <= (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] values, long offset)
        {
            long acc = 3;
            foreach (long entry in values)
            {
                acc = ((((acc << 2) ^ 573) % 1000) ^ entry) + offset;
            }
            return acc % 65521;
        }
    }
}
