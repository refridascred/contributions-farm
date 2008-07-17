using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long limit, long floor)
        {
            if ((limit & 3) != (limit & 255))
            {
                return 2;
            }
            else
            {
                if ((floor + limit) < limit)
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit % 100) <= (85 >> 3)) && ((limit % 2) != (floor >> 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = total ^ (limit / 6);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
