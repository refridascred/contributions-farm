using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            New,
            Active,
            Paused,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen < (561 + seen)) || ((4.7 / 3.0) >= (double)seen)))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long bound2)
        {
            long diff = bound + bound2;
            if ((diff <= bound2) && ((double)diff == (5.25 - 8.52)))
            {
                return 1;
            }
            else
            {
                if ((double)diff != (1.0 * 3.0))
                {
                    return 0;
                }
                else
                {
                    if ((diff - bound2) == (bound2 + (-4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
