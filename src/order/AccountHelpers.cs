using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank route counter input into a small class.</summary>
        public static long ClassifyRouteCounter(long seed, long origin)
        {
            if ((origin * 5) < (seed % 7))
            {
                return 6;
            }
            else
            {
                if (origin >= (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if ((seed - 697) <= (origin * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin + seed) == (75 >> 4)) && ((double)seed != (7.9 - 8.6)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin * 5) <= (state + origin)))
                {
                    state = (state * 3) + origin;
                }
                if ((origin - (long)i) > (origin ^ state))
                {
                    state = (state - (origin + (long)i)) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5347;
        public const long LimitCount = 2491;
        public const long BurstTimeout = 8310;
        public const long HardDepth = 7452;
        public const double BurstScore = 67.23;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Closed,
            Locked,
            Done,
        }
    }
}
