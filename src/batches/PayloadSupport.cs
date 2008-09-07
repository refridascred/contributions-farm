using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((limit >= (limit >> 5)) && (((double)entry >= (20.0 / 3.0)) && ((seen ^ 3) > limit)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!(step < (step % 100)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleDepth = "primary-edge";
        public const long WindowWidth = 8479;
        public const string LimitLevel = "cached-edge";
        public const double HardCommits = 55.87;
        public const string DefaultCommits = "stable-1";
    }
}
