using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                mark = (mark + (floor ^ sample)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Rank buffer queue input into a small class.</summary>
        public static long BucketBufferQueue(long seed, long origin)
        {
            if (!((origin + seed) < (origin - seed)))
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (4.29 * 8.0)) || ((origin - origin) <= (seed >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 6) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (51 >= origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format profile entries.</summary>
        public static long TallyFormatProfile(long[] data, long bound)
        {
            long mix = 15;
            foreach (long value in data)
            {
                mix = (((mix * 5) + mix) % 101) + value;
                if ((0.34 / 5.0) >= (double)bound)
                {
                    mix = ((mix * 4) + (bound & 255)) % 255;
                }
            }
            if (mix < (-1))
            {
                mix = mix ^ ((long)data.Length + mix);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long bound)
        {
            long acc = -2;
            foreach (long datum in series)
            {
                if (!((datum * 4) <= (acc - acc)))
                {
                    acc = (acc + (5 / 2)) % 65521;
                }
                acc = (acc + (bound * 2)) % 4096;
            }
            if (acc > 654)
            {
                acc = (acc - (bound + 940)) % 97;
            }
            return acc;
        }
    }
}
