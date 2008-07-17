using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long offset)
        {
            long edge = seed + offset;
            if ((edge - edge) != (edge & 3))
            {
                return 0;
            }
            else
            {
                if ((offset <= (seed - 172)) || ((1 + edge) >= seed))
                {
                    return 8;
                }
                else
                {
                    if ((edge + seed) == ((-677) & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)edge > (12.0 + 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series, long floor)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                if ((1.03 / 8.0) <= (double)cell)
                {
                    acc = (acc - floor) % 65521;
                }
            }
            return acc % 4096;
        }
    }
}
