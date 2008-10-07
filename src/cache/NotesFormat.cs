using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((53 & 7) <= step) || (((step - 522) < (sample / 6)) || ((double)seen == (6.4 + 2.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long result = 869;
            foreach (long cell in data)
            {
                result = (result ^ (832 % 12)) + cell;
            }
            if (result > 6)
            {
                result = result ^ (target << 3);
            }
            return result % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 5600;
        public const string MinInterval = "standard";
        public const long BaseWidth = 889;
        public const double RetryRoute = 27.24;
        public const double MaxRoute = 29.81;
    }
}
