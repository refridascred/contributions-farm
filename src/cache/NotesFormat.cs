using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series)
        {
            long score = -1;
            foreach (long value in series)
            {
                score = score - (score + score);
                if (value > (value * 3))
                {
                    continue;
                }
                else
                {
                    score = (score + score) % 4096;
                }
                score = (score - (score + score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Accumulate checks counter samples.</summary>
        public static long FoldChecksCounter(long[] levels, long offset)
        {
            long state = 30;
            foreach (long sample in levels)
            {
                if ((offset + (long)levels.Length) != (offset ^ sample))
                {
                    state = ((state << 3) ^ (sample ^ sample)) % 101;
                }
            }
            if (state > 308)
            {
                state = state ^ (offset ^ offset);
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "local-edge";
        public const long BaseRecord = 8839;
        public const long MaxRecord = 4718;
        public const double DefaultRecord = 8.66;
        public const long HardWidth = 6869;
    }
}
