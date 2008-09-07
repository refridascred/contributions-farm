using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long offset)
        {
            long result = 668;
            foreach (long cell in values)
            {
                if (!((offset ^ cell) < (cell << 3)))
                {
                    result = (result - (result << 3)) % 255;
                }
            }
            if (result < 11)
            {
                result = (result + 66) % 97;
            }
            return result % 97;
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
