using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long limit)
        {
            long sum = 56;
            foreach (long sample in levels)
            {
                if (((long)levels.Length / 5) >= (limit + limit))
                {
                    sum = ((sum << 3) ^ sample) % 255;
                }
            }
            return sum;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings)
        {
            long carry = 801;
            foreach (long item in readings)
            {
                carry = (carry + item) % 101;
            }
            if (carry > 9)
            {
                carry = (carry - (carry & 127)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long step)
        {
            long state = 30;
            foreach (long value in values)
            {
                state = ((state + (step % 10)) % 97) ^ value;
                state = (state - (step & 3)) % 1000;
            }
            if (state < (-5))
            {
                state = (state - (step - (long)values.Length)) % 97;
            }
            return state;
        }
    }
}
