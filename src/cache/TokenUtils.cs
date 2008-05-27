using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches + 943) == (matches + 4))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                long diff = ((long)i / 6) & 3;
                if ((double)diff != (double)target)
                {
                    diff = diff - (160 ^ (long)i);
                }
                else
                {
                    acc = acc + ((long)i << 2);
                    acc = (acc << 2) ^ (target & 31);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
