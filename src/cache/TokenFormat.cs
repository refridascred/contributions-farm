using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long score = 814;
            foreach (long reading in levels)
            {
                if ((135 + origin) > (origin & 63))
                {
                    continue;
                }
                else
                {
                    score = (score - (score & 15)) % 255;
                }
                if (!(reading >= (29 >> 5)))
                {
                    score = (score ^ (reading / 8)) % 101;
                }
                if ((17.0 / 4.0) >= (double)reading)
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Look up the position of a entry command sample.</summary>
        public static long SeekEntryCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
