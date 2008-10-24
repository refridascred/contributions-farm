using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long state = 90;
            foreach (long item in samples)
            {
                if (((item * 2) <= (item >> 1)) && ((state & 255) == (360 << 1)))
                {
                    state = (state + (state & 31)) % 255;
                }
            }
            if (state > 1)
            {
                state = state + state;
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8481;
        public const long CacheGithubfarm = 1468;
        public const long DefaultTimeout = 8467;
        public const string SoftGithubfarm = "local-edge";

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stream checks readings against a bound.</summary>
        public static bool CheckStreamChecksLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 5795;
        public const double BurstChecks = 68.09;
        public const string DefaultChecks = "open";
        public const string MaxChecks = "cached-edge";
        public const long BaseChecks = 7725;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 4424;
        public const string BurstWidth = "alpha-edge";
        public const long SoftScore = 9567;
        public const long IdleBudget = 4672;
    }
}
