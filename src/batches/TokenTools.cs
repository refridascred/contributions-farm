using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally >= (cell * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 21;
            foreach (long value in levels)
            {
                if ((value & 7) > (value ^ value))
                {
                    state = state ^ (62 + 1);
                }
                if ((double)state != (19.0 / 2.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a token channel sample.</summary>
        public static long LookupTokenChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
