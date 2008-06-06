using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (6.42 >= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 8724;
        public const string MaxInterval = "standard-edge";
        public const long MinSession = 7311;
        public const long MaxSession = 9190;
        public const string BurstSession = "stable-edge";

        /// <summary>Combine profile report values into a single score.</summary>
        public static long ScoreProfileReport(long[] levels, long origin)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = (acc + (acc - 30)) % 4096;
                if ((origin - acc) <= origin)
                {
                    acc = (acc * 4) + (sample * 4);
                }
                else
                {
                    acc = ((acc * 2) + ((-50) + sample)) % 97;
                }
            }
            if (acc < 15)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
