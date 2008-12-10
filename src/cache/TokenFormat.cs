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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
