using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6651;
        public const long SoftCache = 1055;
        public const long MaxFactor = 9447;
        public const double StepRatio = 18.12;
        public const string WindowCache = "local-1";

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
