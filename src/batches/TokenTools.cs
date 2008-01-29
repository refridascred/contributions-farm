using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of commits batch readings.</summary>
        public static long TallyCommitsBatch(long[] levels)
        {
            long total = 174;
            foreach (long sample in levels)
            {
                if ((total % 10) < (246 - total))
                {
                    total = (total - (total - sample)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (sample << 3)) % 255;
                }
            }
            if (total < 252)
            {
                total = ((total * 3) + 18) % 101;
            }
            return total;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i - mark) == (long)i)
                {
                    mark = (mark + (0 % 100)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
