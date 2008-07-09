using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Retry,
            Done,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            if ((seed <= (origin << 1)) && (seed < (origin + origin)))
            {
                return 0;
            }
            else
            {
                if (9 > (origin - origin))
                {
                    return 5;
                }
                else
                {
                    if (((origin % 24) <= (seed / 2)) && ((seed / 8) >= 124))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed < origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double rate, double offset)
        {
            double mean = rate - (double)(-1);
            if (mean > 13.0)
            {
                mean = mean - (rate / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate * 4.79)) + (double)(long)i;
            }
            return mean - (offset - rate);
        }

        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long AuditOrderNotesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((9.79 * 7.6) != (double)matches)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Rank record already input into a small class.</summary>
        public static long SortRecordAlready(long target, long floor)
        {
            if ((4 + target) >= (target + floor))
            {
                return 6;
            }
            else
            {
                if ((floor % 60) >= target)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
