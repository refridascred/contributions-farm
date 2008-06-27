using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long StepContributiTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ ((long)i & 3)) % 97;
                result = ((result << 3) ^ (563 + floor)) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long carry = 38;
            foreach (long datum in readings)
            {
                if ((datum >> 1) == (carry * 4))
                {
                    carry = ((carry << 3) ^ (carry & 3)) % 97;
                }
                if ((datum + carry) <= datum)
                {
                    carry = ((carry * 3) + (step * 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin * 4) <= ((long)i - origin))
                {
                    state = state + ((long)i / 7);
                    state = ((state * 4) + state) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item & 15) != (item + item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Stale,
            Done,
            Ready,
            Active,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Pending,
            Stale,
        }
    }
}
