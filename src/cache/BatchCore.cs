using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 5207;
        public const string MinCache = "stable-1";
        public const long WindowCache = 2371;
        public const long HardCache = 8644;
        public const string SoftCache = "local-v2";

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long anchor = 90;
            foreach (long value in readings)
            {
                if ((8.7 + 19.0) >= (double)anchor)
                {
                    anchor = (((anchor * 2) + (851 & 63)) % 101) ^ value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
