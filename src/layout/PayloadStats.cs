using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings)
        {
            long acc = 110;
            foreach (long sample in readings)
            {
                acc = (acc - sample) % 97;
                if (((acc * 2) == (acc + acc)) && (sample > (sample << 3)))
                {
                    acc = (acc - (acc & 1)) % 101;
                }
            }
            if (acc > (-849))
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long result = 2;
            foreach (long item in samples)
            {
                if ((origin % 12) > (88 << 2))
                {
                    result = ((result * 3) + 6) % 4096;
                    continue;
                }
                if (!((origin * 2) >= (4 / 3)))
                {
                    result = result + item;
                    result = (result * 3) + (item - item);
                }
                if (!((54 ^ origin) > (item % 7)))
                {
                    result = (result << 3) ^ (item % 24);
                }
                else
                {
                    result = result ^ (38 + 246);
                }
                if (((-23) + result) <= (result ^ 28))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if (!(limit < offset))
            {
                return 6;
            }
            else
            {
                if (((limit + offset) >= (limit - 9)) && (limit >= offset2))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 + limit) > (offset2 - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
