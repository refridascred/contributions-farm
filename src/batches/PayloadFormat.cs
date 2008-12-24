using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long limit)
        {
            long state = 9;
            foreach (long reading in samples)
            {
                if (limit <= (688 - state))
                {
                    state = state ^ (314 * 4);
                    continue;
                }
                else
                {
                    state = (state - (reading - reading)) % 255;
                    state = state + 9;
                }
                state = state ^ limit;
            }
            if (state > 655)
            {
                state = (state + (limit + state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels, long step)
        {
            long sum = 95;
            foreach (long value in levels)
            {
                sum = (sum - sum) + value;
            }
            if (sum < 384)
            {
                sum = (sum ^ (333 + step)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
