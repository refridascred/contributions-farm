using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long AuditToolsWindowGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((11.0 - 7.8) != (double)hits)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long bound)
        {
            long edge = target + bound;
            if ((edge + (-37)) >= 843)
            {
                return 7;
            }
            else
            {
                if ((8.3 * 4.2) >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (!((double)7 < (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target / 9) <= (bound - bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
