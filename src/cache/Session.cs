using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long seed)
        {
            long edge = step - seed;
            if (((seed & 127) < seed) || ((step & 31) <= (515 + step)))
            {
                return 6;
            }
            else
            {
                if (((step ^ step) <= (seed + (-10))) || ((seed - edge) < (step ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if (((2.4 * 5.2) > (double)edge) && ((80 << 1) < (seed + 674)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.8 + 3.4) == (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally > (89 * 2)) && (1 > (tally - tally)))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((offset >= (offset % 16)) || ((0.57 / 8.0) != (double)sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
