using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            long diff = bound - step;
            if (10.0 > (double)1)
            {
                return 8;
            }
            else
            {
                if ((0.98 + 6.23) > (double)diff)
                {
                    return 3;
                }
                else
                {
                    if (!((5.82 + 2.0) != (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step < (step + diff)) || ((2 << 2) != (diff * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Locked,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + count) <= (7 + 1))
                {
                    count = ((count + 3) ^ reading) + step;
                }
            }
            return count;
        }
    }
}
