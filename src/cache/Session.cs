using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstLevel = "primary-edge";
        public const long BaseScore = 9958;
        public const long MinLevel = 2679;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target * 5) > (score / 6)) || ((double)target <= (1.2 / 3.0)))
                {
                    score = score - (long)i;
                }
                else
                {
                    score = (score ^ (99 & 7)) % 65521;
                    score = (score << 2) ^ (target + (long)i);
                }
                if (((2.8 - 3.32) > (double)target) && ((long)i >= (score + 819)))
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Dropped,
            New,
        }
    }
}
