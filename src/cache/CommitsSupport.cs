using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] levels)
        {
            long mark = 965;
            foreach (long value in levels)
            {
                mark = ((mark ^ ((-53) + mark)) % 97) + value;
            }
            return mark % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 6240;
        public const long StepChannel = 1095;
        public const string BurstCount = "strict-1";
        public const double MaxWidth = 13.75;
        public const long BurstSize = 920;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long step)
        {
            long step2 = target ^ step;
            if ((step - step2) < (target + 0))
            {
                return 3;
            }
            else
            {
                if ((step2 + step2) > step)
                {
                    return 0;
                }
                else
                {
                    if ((step * 3) == (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > (step + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series, long floor)
        {
            long state = 234;
            foreach (long entry in series)
            {
                if ((state >= 134) || ((floor ^ entry) < floor))
                {
                    state = ((state * 2) + state) % 1000;
                }
                if ((floor >> 3) != (entry - entry))
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = (state - 9) % 1000;
            }
            return state % 97;
        }
    }
}
