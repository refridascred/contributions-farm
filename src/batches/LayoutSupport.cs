using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits / 3) > ((long)data.Length * 3))
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            if ((4.5 - 4.3) > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((79 >= (offset + offset)) && ((offset2 << 1) < offset2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long step)
        {
            if (((double)step <= (20.0 * 5.24)) || ((double)step > (4.94 + 20.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (6.7 - 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (1.32 * 2.16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8.1 + 3.04) > (double)origin) && ((origin << 3) >= 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Paused,
            Locked,
        }
    }
}
