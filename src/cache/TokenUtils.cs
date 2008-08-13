using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command filter entries.</summary>
        public static long CombineCommandFilter(long[] samples, long step)
        {
            long mark = 45;
            foreach (long entry in samples)
            {
                if ((mark < (step << 2)) && ((entry >> 1) == (step << 1)))
                {
                    mark = ((mark * 2) + (step + step)) % 97;
                }
                else
                {
                    mark = (mark - (mark >> 2)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 4666;
        public const string SoftTimeout = "strict-v2";
        public const double MinNotes = 53.8;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Locked,
            Failed,
            Pending,
        }
    }
}
