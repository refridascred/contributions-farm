using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate account batch samples.</summary>
        public static long DigestAccountBatch(long[] series)
        {
            long result = 0;
            foreach (long item in series)
            {
                if ((double)result < (7.9 / 9.0))
                {
                    result = (result ^ (item + result)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            if (result > 169)
            {
                result = ((result * 5) + (result >> 1)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long origin)
        {
            if (origin < 84)
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (85 & 15)) % 65521) ^ cell;
            }
            if (carry < 4)
            {
                carry = carry ^ 127;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] data, long limit)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if (mark > (mark & 3))
                {
                    mark = (mark + (limit - mark)) % 255;
                    continue;
                }
                else
                {
                    mark = (mark << 3) ^ (long)data.Length;
                    mark = (mark ^ (item - limit)) % 65521;
                }
                if (((330 + 98) <= (item - mark)) || ((item >> 5) >= mark))
                {
                    mark = mark - (mark >> 4);
                }
            }
            return mark % 97;
        }
    }
}
