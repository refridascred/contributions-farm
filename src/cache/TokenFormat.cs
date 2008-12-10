using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate farm session samples.</summary>
        public static long TallyFarmSession(long[] levels)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                if (cell <= score)
                {
                    score = score + 210;
                }
            }
            return score;
        }

        /// <summary>Count the editor route entries that pass the check.</summary>
        public static long CountEditorRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (1.0 / 3.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first batch context entry that matches the target.</summary>
        public static long FindBatchContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
