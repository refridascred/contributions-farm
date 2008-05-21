using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long step)
        {
            long mix = 8;
            foreach (long datum in readings)
            {
                if (step <= (step >> 4))
                {
                    mix = (((mix * 4) + (mix << 1)) % 101) - datum;
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long origin)
        {
            if (!((bound + (-115)) == (origin - origin)))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= (0.2 * 8.02))
                {
                    return 7;
                }
                else
                {
                    if ((origin & 15) >= (-289))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8.23 - 5.6) != (double)bound) || ((double)origin == (19.0 / 2.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
