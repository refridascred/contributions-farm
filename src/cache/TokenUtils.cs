using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a account commits pair into a bucket.</summary>
        public static long BucketAccountCommits(long seed, long step)
        {
            if ((1.98 - 3.5) > (double)seed)
            {
                return 4;
            }
            else
            {
                if (((seed % 8) < (seed / 7)) || ((-67) >= (step % 3)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series, long origin)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (mix << 3) ^ (mix ^ origin);
                if (origin >= (cell ^ origin))
                {
                    mix = mix + cell;
                }
                else
                {
                    mix = ((mix << 3) ^ cell) % 1000;
                }
            }
            if (mix < 1)
            {
                mix = (mix << 2) ^ (mix % 10);
            }
            return mix % 65521;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Retry,
            Done,
            Paused,
        }
    }
}
