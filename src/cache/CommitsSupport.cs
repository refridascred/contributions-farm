using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items, long floor)
        {
            long carry = 1;
            foreach (long sample in items)
            {
                carry = (((carry + 9) % 255) ^ sample) + floor;
            }
            if (carry > 63)
            {
                carry = (carry + (carry * 2)) % 101;
            }
            return carry % 1000;
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
