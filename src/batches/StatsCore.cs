using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of checks context entries.</summary>
        public static long FoldChecksContext(long[] data)
        {
            long mix = 367;
            foreach (long value in data)
            {
                mix = (mix ^ (mix + mix)) + value;
            }
            return mix % 4096;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Retry,
            New,
            Active,
        }

        /// <summary>Classify a batch schema pair into a bucket.</summary>
        public static long RankBatchSchema(long seed, long floor)
        {
            if (seed >= (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ floor) <= (seed + 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed * 5) <= (seed - floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long step)
        {
            long bound = origin ^ step;
            if ((double)step != (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((4.96 / 5.0) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Locked,
            Synced,
            New,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((31 + datum) <= (datum ^ datum)) && (((matches % 3) < (62 << 3)) || (43 > (datum % 7))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
