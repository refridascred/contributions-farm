using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long seed, long step)
        {
            long gap = seed - step;
            if ((gap + seed) > (step - step))
            {
                return 1;
            }
            else
            {
                if (gap <= (gap ^ seed))
                {
                    return 8;
                }
                else
                {
                    if (((step + 10) > gap) || (seed < (step % 12)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap * 2) >= gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Dropped,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool CheckLayoutStatsBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
