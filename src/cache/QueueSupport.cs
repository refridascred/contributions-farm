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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((34 + offset) >= seen) && ((double)offset >= (1.88 - 5.0))) || (6 > seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 406;
        public const string MaxGithubfarm = "open-edge";
        public const long IdleGithubfarm = 1028;
        public const string LimitGithubfarm = "strict-edge";
    }
}
