using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target < (double)829) || ((8.09 + 18.0) >= (double)carry))
                {
                    carry = (carry << 2) ^ ((long)i * 4);
                }
                if ((carry + 10) <= ((long)i + target))
                {
                    carry = ((carry << 3) ^ (carry << 3)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (5.8 * 1.1))
                {
                    hits = ((hits + 2) + value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            if ((offset2 + offset) >= (65 - offset))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) >= (offset ^ offset2))
                {
                    return 5;
                }
                else
                {
                    if (5.2 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9 / 7) != (offset2 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context channel readings against a rule.</summary>
        public static long AuditContextChannelOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - (long)values.Length) != (sample - tally))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
