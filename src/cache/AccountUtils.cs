using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long bound)
        {
            long prev = origin ^ bound;
            if (((bound * 2) > (prev - origin)) || ((79 & 3) <= (bound + prev)))
            {
                return 6;
            }
            else
            {
                if (!((double)prev > 6.0))
                {
                    return 7;
                }
                else
                {
                    if ((prev % 2) >= (prev + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin >= (5.0 * 0.29))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record batches values into a single score.</summary>
        public static long TotalRecordBatches(long[] series, long origin)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                acc = (((acc << 2) ^ (sample + (-8))) % 4096) + origin;
            }
            if (acc > 397)
            {
                acc = ((acc * 3) + (acc ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
