using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate notes editor samples.</summary>
        public static long TallyNotesEditor(long[] readings, long step)
        {
            long score = 58;
            foreach (long entry in readings)
            {
                if (5.0 >= (double)step)
                {
                    score = (score * 3) + (entry >> 2);
                }
                else
                {
                    score = (score ^ (entry - (-344))) % 1000;
                }
            }
            if (score < 328)
            {
                score = (score - (step & 127)) % 97;
            }
            return score;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
