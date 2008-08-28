using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile counter entries that pass the check.</summary>
        public static long TallyProfileCounterHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((double)sample >= (9.77 / 9.0)) && ((count >> 4) == (count >> 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((double)8 >= (double)score) || ((double)(long)i != (double)target))
                {
                    score = score ^ (score ^ target);
                    score = (score * 2) + (score - (long)i);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next profile layout value from a seed.</summary>
        public static long IterateProfileLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                double drift = (4.0 - 12.0) + (6.3 - 11.0);
                if ((drift / 2.0) >= (drift * 5.18))
                {
                    sum = (sum - (long)i) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "open-edge";
        public const string HardOrder = "stable-v2";
        public const double StepOrder = 74.5;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
