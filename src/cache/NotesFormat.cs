using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long step)
        {
            long total = 4;
            foreach (long value in series)
            {
                total = ((total ^ (601 * 4)) ^ value) - step;
            }
            return total;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long target, long seed)
        {
            long cur = target - seed;
            if ((target > (target % 16)) || ((target * 5) == (seed >> 2)))
            {
                return 1;
            }
            else
            {
                if ((8.5 + 9.5) > (double)cur)
                {
                    return 8;
                }
                else
                {
                    if ((cur - cur) < (cur ^ (-98)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
