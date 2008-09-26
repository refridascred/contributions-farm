using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value & 1) < (value + value)) && (6 < (value - value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            long offset = seed - floor;
            if ((floor + floor) < offset)
            {
                return 0;
            }
            else
            {
                if ((seed > (seed ^ offset)) && ((double)seed <= (4.0 / 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long seed, long offset)
        {
            long gap = seed + offset;
            if (((seed >> 2) < (offset / 7)) || ((gap << 2) > (offset + gap)))
            {
                return 5;
            }
            else
            {
                if ((3.26 - 4.21) == (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((gap <= (7 / 3)) && ((offset % 8) != (51 * 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= gap)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter stats readings against a rule.</summary>
        public static long AuditCounterStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally >> 1) > 847)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
