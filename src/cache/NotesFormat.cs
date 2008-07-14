using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long target)
        {
            if ((step % 7) < 8)
            {
                return 8;
            }
            else
            {
                if (((step >> 5) >= (step * 4)) && ((step + target) != (step + step)))
                {
                    return 4;
                }
                else
                {
                    if (!((target + target) >= (66 * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((20.0 * 0.3) <= (double)matches) || (((value ^ matches) <= matches) && ((value << 1) <= ((long)items.Length & 7))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
