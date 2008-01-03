using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile tools entries that pass the check.</summary>
        public static long TallyProfileToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item + 86) >= item) || ((item + seen) <= (seen - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long step, long limit)
        {
            if (step > (29 & 63))
            {
                return 5;
            }
            else
            {
                if (7.0 >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((limit - step) != (step - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (limit - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
