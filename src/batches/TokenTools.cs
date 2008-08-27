using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels)
        {
            long sum = 48;
            foreach (long entry in levels)
            {
                sum = (((sum * 2) + 9) % 101) ^ entry;
            }
            return sum;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry % 100) > seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
