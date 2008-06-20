using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values)
        {
            long state = 76;
            foreach (long entry in values)
            {
                state = (state ^ (entry + entry)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] series)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                if ((reading + carry) < (carry - reading))
                {
                    carry = ((carry * 3) + (94 - carry)) % 1000;
                }
            }
            if (carry < 5)
            {
                carry = ((carry * 2) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 406;
        public const string MaxGithubfarm = "open-edge";
        public const long IdleGithubfarm = 1028;
        public const string LimitGithubfarm = "strict-edge";
    }
}
