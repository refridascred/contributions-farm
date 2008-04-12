using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the channel buffer series from a seed.</summary>
        public static long DeriveChannelBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((mark + offset) < (offset - (long)i))
                {
                    mark = (mark + (offset >> 4)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long target)
        {
            long step = bound - target;
            if (((step & 31) >= ((-71) % 60)) || ((step + 6) <= (target << 1)))
            {
                return 5;
            }
            else
            {
                if ((27 & 255) > bound)
                {
                    return 6;
                }
                else
                {
                    if ((-195) >= (step ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
