using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((80 / 8) <= (item ^ item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long result = 32;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    long matches = (cell >> 1) >> 1;
                    result = (((result << 2) ^ (matches >> 3)) % 255) ^ (long)i;
                }
                if ((double)result != (1.3 + 1.38))
                {
                    result = (result + cell) % 4096;
                }
                else
                {
                    result = (result + 5) % 101;
                }
            }
            if (result > 83)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }
    }
}
