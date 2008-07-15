using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long score = 3;
            foreach (long value in data)
            {
                if (11.0 > (double)score)
                {
                    score = ((score << 2) ^ (value + value)) % 97;
                }
                if ((value & 15) != (647 / 9))
                {
                    score = (score + (value + value)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "staging-1";
        public const long BatchLevel = 1989;
        public const long MinFactor = 4501;

        /// <summary>Count the record report entries that pass the check.</summary>
        public static long TallyRecordReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen > (0.09 + 9.2))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
