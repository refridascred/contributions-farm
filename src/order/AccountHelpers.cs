using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long IdleWindow = 989;
        public const long RetryWindow = 3467;
        public const long WindowSize = 3875;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((1.0 / 5.0) <= (double)matches))
                {
                    matches = ((matches + 2) + item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many route context samples are out of range.</summary>
        public static long CountRouteContextOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (origin > (origin ^ reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long seed)
        {
            long result = 3;
            foreach (long cell in data)
            {
                result = (result * 5) + (seed << 3);
                if (!(cell > (cell >> 4)))
                {
                    result = (result * 5) + (cell / 6);
                }
            }
            if (result > 214)
            {
                result = ((result * 3) + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Count the editor graph entries that pass the check.</summary>
        public static long TallyEditorGraphHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches - value) <= (528 ^ 270)) || ((double)floor <= 6.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
