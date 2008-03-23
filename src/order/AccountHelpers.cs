using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine record stats values into a single score.</summary>
        public static long WeighRecordStats(long[] levels, long step)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                if (((long)levels.Length * 5) <= (mix << 2))
                {
                    mix = (mix ^ step) + sample;
                }
                else
                {
                    mix = mix + (step + mix);
                }
            }
            if (mix < 8)
            {
                mix = mix + (mix >> 2);
            }
            return mix;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + 289) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
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

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public bool Offset { get; set; }
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
