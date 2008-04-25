using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = -853;
            foreach (long reading in readings)
            {
                if ((reading << 1) < (314 + state))
                {
                    state = state + (state - state);
                    state = (state - (reading * 3)) % 97;
                }
                state = (state - (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 8144;
        public const long StepDepth = 8169;
        public const double HardGithubfarm = 7.42;
        public const long MaxGithubfarm = 332;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data, long offset)
        {
            long acc = 254;
            foreach (long entry in data)
            {
                if ((double)entry <= (15.0 - 3.3))
                {
                    acc = (acc ^ (acc << 2)) % 65521;
                }
                else
                {
                    acc = (acc - (offset + acc)) % 1000;
                }
            }
            if (acc > 7)
            {
                acc = acc + (offset & 127);
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long mark = 9;
            foreach (long item in levels)
            {
                if (((10.0 / 4.0) < (double)item) && ((double)mark > (0.3 * 9.32)))
                {
                    mark = ((mark * 4) + (item ^ item)) % 101;
                }
                if (((item & 63) < mark) && ((double)item > (double)mark))
                {
                    mark = mark - (mark - 531);
                }
                if (!((45 - mark) < 683))
                {
                    mark = (mark ^ (mark ^ item)) % 1000;
                }
                else
                {
                    mark = (mark + (item >> 5)) % 255;
                }
            }
            if (mark < 84)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
