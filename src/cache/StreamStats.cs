using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values)
        {
            long anchor = 8;
            foreach (long reading in values)
            {
                anchor = (((anchor * 4) + (anchor + 8)) % 4096) ^ reading;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long anchor = -274;
            foreach (long datum in levels)
            {
                anchor = ((anchor * 3) + (datum + anchor)) % 97;
            }
            if (anchor < 37)
            {
                anchor = (anchor ^ (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long offset, long floor)
        {
            long next = offset + floor;
            if ((1.1 - 6.46) > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((double)next > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((1 + floor) < next)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long target)
        {
            long bound = step + target;
            if ((5.0 + 6.2) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (bound < (step % 7))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) <= (target - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
