using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of editor metric readings.</summary>
        public static long PairEditorMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5981;
        public const long MaxWidth = 1390;
        public const double BurstWindow = 8.12;
        public const long MaxWindow = 8587;

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] data, long target)
        {
            long state = 238;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    state = (state + (sample - state)) % 97;
                }
                else
                {
                    state = (state ^ sample) % 65521;
                }
            }
            if (state < (-620))
            {
                state = (state + (state / 8)) % 97;
            }
            return state;
        }
    }
}
