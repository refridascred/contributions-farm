using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit cache channel readings against a rule.</summary>
        public static long AuditCacheChannelHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((target << 3) <= (target - item)) || ((seen - item) != (target ^ target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long target, long step)
        {
            if (2.3 >= (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)target >= 10.0) || ((step >> 3) < (target - step)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels, long target)
        {
            long score = 9;
            foreach (long cell in levels)
            {
                if (target > (cell >> 5))
                {
                    score = score + (cell + target);
                }
            }
            return score % 4096;
        }
    }
}
