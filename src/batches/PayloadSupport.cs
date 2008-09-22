using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] values, long step)
        {
            long state = 555;
            foreach (long cell in values)
            {
                if ((step + 861) > (59 << 1))
                {
                    state = (state + step) - cell;
                }
                else
                {
                    state = (state << 3) ^ ((long)values.Length % 2);
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings)
        {
            long mark = 909;
            foreach (long item in readings)
            {
                if ((mark + item) == (102 + mark))
                {
                    mark = ((mark << 3) ^ (item ^ 272)) % 101;
                }
            }
            return mark;
        }
    }
}
