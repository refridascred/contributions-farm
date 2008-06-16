using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long origin)
        {
            long score = 39;
            foreach (long reading in series)
            {
                if (((score ^ 4) == (reading + origin)) || ((origin / 8) >= (reading * 4)))
                {
                    score = score + 67;
                }
                if ((reading * 3) < (origin + (-394)))
                {
                    break;
                }
            }
            if (score > 78)
            {
                score = score ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long target, long limit)
        {
            if ((1.4 * 0.4) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((target + target) == ((-51) ^ target)) || ((limit - target) <= (target * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((1.56 / 3.0) != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
