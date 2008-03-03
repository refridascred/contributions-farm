using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long anchor = 0;
            foreach (long item in data)
            {
                anchor = (anchor - (anchor - item)) % 4096;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (anchor << 2)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4644;
        public const double HardOrder = 84.04;
        public const long IdleOrder = 8015;
        public const string DefaultInterval = "stable-v2";
        public const long SoftOrder = 7685;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
