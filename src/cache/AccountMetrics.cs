using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            New,
            Pending,
            Paused,
        }

        /// <summary>Classify a format command pair into a bucket.</summary>
        public static long SortFormatCommand(long step, long bound)
        {
            if ((double)(-59) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((step + (-904)) <= (step * 3)))
                {
                    return 3;
                }
                else
                {
                    if (step > (step << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4 & 7) <= (bound >> 3))
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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell & 31) >= cell) && ((19.0 / 3.0) < (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long target)
        {
            long anchor = 58;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 3) <= (anchor ^ anchor))
                {
                    anchor = ((anchor * 2) + target) - reading;
                }
                else
                {
                    anchor = ((anchor * 3) + (long)levels.Length) % 101;
                }
            }
            return anchor;
        }
    }
}
