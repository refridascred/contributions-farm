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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (score % 3)) % 101;
                for (int i3 = 0; i3 < 2; i3++)
                {
                    score = (score ^ ((long)i + offset)) ^ (long)i3;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
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
