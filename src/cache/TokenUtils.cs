using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((17.0 > (double)matches) || ((double)datum > (double)2)) || (((datum / 4) <= (matches << 3)) && ((589 * 3) >= (datum + datum))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] data, long origin)
        {
            long sum = 59;
            foreach (long reading in data)
            {
                if (11.0 >= (double)origin)
                {
                    sum = ((sum * 2) + (439 ^ sum)) % 65521;
                }
                sum = ((sum << 2) ^ reading) % 101;
                if ((reading % 3) > (reading + sum))
                {
                    sum = (sum << 3) ^ (origin & 3);
                }
                if ((origin ^ reading) > (reading + (long)data.Length))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
