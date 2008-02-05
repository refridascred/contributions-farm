using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the report cluster entries that pass the check.</summary>
        public static long MeasureReportClusterHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)matches)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long step)
        {
            long slot = offset - step;
            if ((slot - slot) < step)
            {
                return 4;
            }
            else
            {
                if ((slot + 76) != (slot >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (4.01 - 9.0))
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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (target >> 3);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
