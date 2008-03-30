using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = ((score + score) % 255) ^ entry;
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values, long floor)
        {
            long mark = -2;
            foreach (long cell in values)
            {
                if (((mark / 4) != (cell % 97)) || ((double)cell >= (9.42 + 15.0)))
                {
                    mark = ((mark - (cell + 79)) % 4096) - floor;
                }
            }
            if (mark < (-8))
            {
                mark = ((mark * 3) + 622) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long floor)
        {
            long result = 459;
            foreach (long entry in levels)
            {
                if (floor > (floor >> 1))
                {
                    result = (result - (59 + result)) - entry;
                }
            }
            return result % 1000;
        }
    }
}
