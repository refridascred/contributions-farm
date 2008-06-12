using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell + origin) == (origin + 73))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((-817) + (long)i) != ((long)i / 7))
                {
                    state = (state ^ state) % 4096;
                }
                if ((7.13 + 16.0) <= (double)(long)i)
                {
                    state = (state - (state & 255)) % 1000;
                    state = ((state << 2) ^ offset) % 65521;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long offset, long target)
        {
            if (((double)(-6) <= (double)target) || (0 >= (target >> 4)))
            {
                return 7;
            }
            else
            {
                if ((2 << 1) > target)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
