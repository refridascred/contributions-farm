using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long limit)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if (limit >= ((long)readings.Length ^ value))
                {
                    carry = (carry + (carry - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 5) + (804 + carry);
            }
            return carry;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < 99)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings)
        {
            long score = 52;
            foreach (long item in readings)
            {
                score = (((score * 3) + (793 - 6)) % 1000) ^ item;
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
