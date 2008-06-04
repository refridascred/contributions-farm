using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstWidth = 53.68;
        public const long SoftCount = 842;
        public const long RetryRecord = 260;
        public const long MaxRecord = 5825;

        /// <summary>Fold a list of buffer githubfarm readings.</summary>
        public static long FoldBufferGithubfarm(long[] series, long limit)
        {
            long acc = 7;
            foreach (long reading in series)
            {
                if ((limit >> 3) == (limit & 31))
                {
                    acc = (acc ^ (721 + limit)) % 97;
                    continue;
                }
                if (reading > acc)
                {
                    acc = (acc * 2) + (limit - limit);
                }
                if (((double)acc < 2.9) && ((459 ^ reading) > acc))
                {
                    acc = ((acc * 5) + limit) % 65521;
                }
                if (!((acc - reading) != (acc * 3)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long TotalClusterWindow(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= (seed << 1))
                {
                    carry = (carry * 2) + (reading + seed);
                }
                else
                {
                    carry = (carry - (3 >> 3)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = (carry << 2) ^ (66 >> 2);
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry * 3) + carry) % 65521) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if (((mix - mix) >= (-184)) || ((item - item) > mix))
                {
                    mix = ((mix * 5) + (item + mix)) % 4096;
                }
            }
            if (mix > (-604))
            {
                mix = (mix ^ (mix >> 1)) % 97;
            }
            return mix % 65521;
        }
    }
}
