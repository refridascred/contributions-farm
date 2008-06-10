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

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ 346;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of payload command entries.</summary>
        public static long TallyPayloadCommand(long[] series)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                if (((461 + mark) != (mark % 3)) && (reading > (mark ^ reading)))
                {
                    mark = mark - (mark + reading);
                }
            }
            if (mark < 7)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark % 97;
        }
    }
}
