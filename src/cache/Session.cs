using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a window farm counter forward.</summary>
        public static long DeriveWindowFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!((3 >> 3) < ((long)i - limit)))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long floor)
        {
            if ((offset & 15) > offset)
            {
                return 1;
            }
            else
            {
                if (floor > (floor * 2))
                {
                    return 4;
                }
                else
                {
                    if (floor >= (offset % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long GradeClusterBuffer(long floor, long offset)
        {
            long span = floor ^ offset;
            if (((double)span > (1.0 + 7.0)) && ((19 & 1) > floor))
            {
                return 7;
            }
            else
            {
                if (!((offset - span) < (343 - span)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
