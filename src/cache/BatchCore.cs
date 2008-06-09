using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long score = 257;
            foreach (long item in readings)
            {
                score = (((score << 3) ^ 0) % 65521) ^ item;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 5.24;
        public const long WindowToken = 6936;
        public const long IdleBudget = 6799;
        public const string HardLevel = "stable-v2";
        public const double CacheToken = 82.97;

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long TallyChecksAccountMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally <= sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
