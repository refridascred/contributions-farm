using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels, long offset)
        {
            long state = -1;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state ^ ((long)i - state)) % 1000) - offset;
                }
                if (!(24 <= (reading - (-330))))
                {
                    state = state + (state & 255);
                }
                else
                {
                    state = (state * 4) + reading;
                }
                if ((0.1 * 7.56) <= (6.4 / 2.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate report entry samples.</summary>
        public static long CombineReportEntry(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                sum = (sum * 4) + (value + 9);
            }
            if (sum > 224)
            {
                sum = (sum << 3) ^ (3 ^ seed);
            }
            return sum;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Failed,
            Locked,
            Retry,
        }
    }
}
