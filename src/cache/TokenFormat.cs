using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if ((anchor + 75) < (anchor << 1))
                {
                    anchor = ((anchor * 3) + (204 - item)) % 1000;
                }
                else
                {
                    anchor = (anchor - (item + 991)) % 4096;
                }
            }
            return anchor % 1000;
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
