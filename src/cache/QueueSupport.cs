using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((mark >> 1) > (target + (long)i)))
                {
                    mark = ((mark << 3) ^ (mark + target)) % 101;
                }
                if (!(target <= 30))
                {
                    mark = (mark * 3) + ((long)i ^ 5);
                    break;
                }
                else
                {
                    mark = (mark + 16) % 255;
                    mark = (mark * 5) + target;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank command commits input into a small class.</summary>
        public static long GradeCommandCommits(long origin, long floor)
        {
            long cur = origin ^ floor;
            if (((origin * 3) >= origin) && ((origin + floor) > cur))
            {
                return 4;
            }
            else
            {
                if ((cur / 8) < (364 - floor))
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
