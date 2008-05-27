using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank filter metrics input into a small class.</summary>
        public static long GradeFilterMetrics(long floor, long seed)
        {
            if ((seed + 8) <= (floor / 8))
            {
                return 8;
            }
            else
            {
                if (((floor % 97) > (seed ^ floor)) && ((0.14 + 2.73) > (double)seed))
                {
                    return 3;
                }
                else
                {
                    if (8 < seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor << 3) < floor) || (337 >= floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if (((total - step) < 2) || ((13.0 + 4.0) != (double)(long)i))
                {
                    total = ((total << 2) ^ (-229)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
