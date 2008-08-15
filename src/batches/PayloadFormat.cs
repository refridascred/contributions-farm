using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target - target) < (target * 5))
                {
                    mix = (mix ^ ((long)i * 3)) % 4096;
                    mix = ((mix << 2) ^ ((long)i ^ 75)) % 255;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long acc = 17;
            foreach (long sample in items)
            {
                if ((sample * 5) < sample)
                {
                    acc = acc ^ (acc / 8);
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
