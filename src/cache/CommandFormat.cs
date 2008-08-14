using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a metric window value against two limits.</summary>
        public static long GradeMetricWindow(long origin, long limit)
        {
            if (((limit - limit) > (origin + 4)) || (limit < (limit >> 3)))
            {
                return 5;
            }
            else
            {
                if ((double)origin != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit % 7) >= (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((offset ^ offset) == (offset + cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next session format value from a seed.</summary>
        public static long DeriveSessionFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + offset) % 4096;
                sum = (sum * 3) + (sum & 31);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
