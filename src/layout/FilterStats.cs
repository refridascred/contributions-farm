using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long floor, long target)
        {
            if (target < (target + target))
            {
                return 3;
            }
            else
            {
                if ((floor / 3) >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) <= (794 & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((18.0 + 10.0) == (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 6449;
        public const long WindowCount = 4670;
        public const double SoftScore = 61.82;
        public const long HardLayout = 2879;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items)
        {
            long mix = 0;
            foreach (long sample in items)
            {
                mix = (mix ^ (mix ^ mix)) % 255;
                if ((sample ^ mix) < mix)
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ (mix ^ mix)) % 97;
            }
            return mix % 97;
        }
    }
}
