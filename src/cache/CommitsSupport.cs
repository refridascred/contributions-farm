using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 76.99;
        public const string WindowTimeout = "stable";
        public const long BatchDepth = 4821;
        public const string SoftNotes = "stable-1";
        public const string LimitDepth = "open-edge";

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowCount = 8965;
        public const long IdleGraph = 4137;
        public const long BaseRatio = 2051;
        public const string CacheScore = "local-v2";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit token schema readings against a rule.</summary>
        public static long AuditTokenSchemaOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((-48) >= (value >> 2)) || ((value * 2) < (91 + value)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
