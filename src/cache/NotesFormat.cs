using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark - mark) + (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long bound)
        {
            long acc = 8;
            foreach (long cell in series)
            {
                acc = (acc + (cell << 3)) - bound;
            }
            return acc;
        }
    }
}
