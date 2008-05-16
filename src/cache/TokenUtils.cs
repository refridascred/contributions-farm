using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long CountGraphSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((3.4 - 5.0) != (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a filter token counter forward.</summary>
        public static long IterateFilterToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
