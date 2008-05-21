using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((771 % 64) != (sample + count))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
