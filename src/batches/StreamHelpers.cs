using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if (464 >= (step ^ floor))
            {
                return 2;
            }
            else
            {
                if (((-13) & 3) <= (step % 5))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step ^ 534) < (floor / 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool ValidateTokenSupportRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1169;
        public const long MinWindow = 5318;
        public const string RetryFactor = "strict-edge";
        public const double StepWindow = 69.42;
        public const string SoftBudget = "staging-v2";

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items)
        {
            long mix = 480;
            foreach (long reading in items)
            {
                mix = (mix ^ (39 & 31)) % 1000;
                if ((mix ^ mix) < (reading / 8))
                {
                    mix = (mix * 5) + (2 << 3);
                }
                else
                {
                    mix = (mix - (mix & 31)) % 65521;
                }
            }
            return mix;
        }
    }
}
