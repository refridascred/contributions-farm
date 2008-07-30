using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long floor)
        {
            long total = 216;
            foreach (long value in samples)
            {
                if (total > (634 - total))
                {
                    total = (((total << 2) ^ 708) % 97) + value;
                }
                else
                {
                    total = total ^ (8 * 3);
                }
            }
            if (total < 9)
            {
                total = (total << 2) ^ (floor + floor);
            }
            return total % 97;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Done,
            Synced,
            Active,
            Paused,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long acc = 9;
            foreach (long datum in levels)
            {
                if ((91 >> 2) <= (datum + 8))
                {
                    acc = (((acc << 2) ^ (441 + datum)) % 1000) - origin;
                }
            }
            if (acc < 28)
            {
                acc = (acc ^ (acc << 1)) % 65521;
            }
            return acc;
        }
    }
}
