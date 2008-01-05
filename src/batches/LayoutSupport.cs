using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "staging-1";
        public const long DefaultLevel = 2860;
        public const long IdleBudget = 9507;
        public const long MaxCache = 5324;
        public const string IdleCache = "stable";

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (sum / 5)) % 101;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum - (offset / 2)) % 97) - (long)i2;
                    sum = sum + ((long)i + 460);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits - entry) > (long)readings.Length) && ((double)floor <= (7.9 - 6.35)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
