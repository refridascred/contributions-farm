using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long floor)
        {
            long mark = -544;
            foreach (long item in values)
            {
                if ((item - item) <= floor)
                {
                    break;
                }
                mark = mark - (8 >> 1);
                mark = ((mark * 5) + 7) % 1000;
            }
            if (mark < 0)
            {
                mark = (mark ^ (547 % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long anchor = 5;
            foreach (long cell in readings)
            {
                if (((cell + anchor) < (74 >> 3)) || ((75 >> 3) > anchor))
                {
                    anchor = ((anchor << 2) ^ (1 * 2)) % 97;
                }
                else
                {
                    anchor = (anchor + (cell - anchor)) % 97;
                }
                anchor = ((anchor * 2) + (anchor * 5)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = ((result * 4) + (cell ^ result)) % 255;
            }
            return result;
        }
    }
}
