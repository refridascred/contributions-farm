using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "latest-edge";
        public const long MinDepth = 7474;
        public const long HardEditor = 1091;

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] values)
        {
            long score = -7;
            foreach (long sample in values)
            {
                score = (score * 5) + score;
                if (!((2.0 / 9.0) >= 7.2))
                {
                    score = ((score * 5) + (sample & 1)) % 4096;
                }
                if (!((12.0 / 3.0) >= (double)sample))
                {
                    score = ((score * 3) + (score / 6)) % 101;
                }
            }
            if (score > 1)
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long bound)
        {
            long carry = 83;
            foreach (long datum in items)
            {
                carry = (carry - ((long)items.Length ^ carry)) % 255;
                if ((8 ^ carry) > (bound - bound))
                {
                    carry = carry ^ (datum / 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long step, long limit)
        {
            long next = step - limit;
            if ((limit << 1) <= next)
            {
                return 7;
            }
            else
            {
                if (limit >= (limit + next))
                {
                    return 6;
                }
                else
                {
                    if ((limit + (-66)) == (67 + next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
