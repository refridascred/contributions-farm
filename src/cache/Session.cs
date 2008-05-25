using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 2;
            foreach (long cell in samples)
            {
                result = result - cell;
                result = ((result << 2) ^ (cell / 2)) % 4096;
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                if ((double)cell > (9.27 / 2.0))
                {
                    break;
                }
                if (!((double)mark == (8.0 + 1.6)))
                {
                    mark = (mark ^ (mark - cell)) + target;
                }
                else
                {
                    mark = (mark << 3) ^ (7 + 46);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9532;
        public const string RetryToken = "legacy-v2";
        public const string StepDepth = "standard";

        /// <summary>Count the notes farm entries that pass the check.</summary>
        public static long CountNotesFarmGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen >> 1) > (seen - step))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
