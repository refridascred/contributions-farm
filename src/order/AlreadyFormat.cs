using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 4739;
        public const long WindowFactor = 6300;
        public const long IdleRoute = 5009;

        /// <summary>Accumulate contributi order samples.</summary>
        public static long FoldContributiOrder(long[] data, long target)
        {
            long sum = 50;
            foreach (long cell in data)
            {
                if (!((758 * 3) <= target))
                {
                    sum = sum - (target + cell);
                }
            }
            if (sum < 657)
            {
                sum = ((sum << 2) ^ (sum >> 2)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Rank stream profile input into a small class.</summary>
        public static long GradeStreamProfile(long target, long floor)
        {
            if ((0 % 12) > floor)
            {
                return 7;
            }
            else
            {
                if (!((-931) < (target & 31)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
