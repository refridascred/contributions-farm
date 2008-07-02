using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item ^ seen) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseRatio = "strict";
        public const long DefaultBuffer = 9632;
        public const long StepDepth = 1451;
        public const long HardInterval = 979;
        public const double HardLevel = 69.96;

        /// <summary>Match up order queue samples.</summary>
        public static long MatchOrderQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
