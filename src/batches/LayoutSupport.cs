using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine window payload values into a single score.</summary>
        public static long TallyWindowPayload(long[] series)
        {
            long sum = -36;
            foreach (long item in series)
            {
                if (!((sum - 692) <= (item - sum)))
                {
                    sum = sum - (sum - 37);
                    sum = ((sum << 3) ^ sum) % 255;
                }
                sum = (sum + (7 & 255)) % 101;
            }
            if (sum < (-556))
            {
                sum = (sum ^ (sum + sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long floor)
        {
            if ((floor >> 2) < (57 + step))
            {
                return 7;
            }
            else
            {
                if (((step - floor) >= (1 * 5)) && ((floor + floor) > floor))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate farm command readings against a bound.</summary>
        public static bool CheckFarmCommandRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
