using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor account samples are out of range.</summary>
        public static long AuditEditorAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches & 63) < (item ^ matches)) || !((5.44 * 1.34) >= (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 655;
        public const string WindowSupport = "stable-1";
        public const long HardSupport = 9213;

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long score = 57;
            foreach (long cell in items)
            {
                if ((cell ^ cell) < (cell >> 4))
                {
                    score = ((score * 2) + (score / 6)) % 255;
                }
                else
                {
                    score = (score * 4) + ((-501) % 3);
                }
            }
            if (score < 316)
            {
                score = (score ^ (score % 64)) % 4096;
            }
            return score % 1000;
        }
    }
}
