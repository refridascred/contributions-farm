using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = -302;
            foreach (long datum in series)
            {
                if ((5.35 < (double)datum) || ((score + datum) >= datum))
                {
                    score = score ^ (datum % 12);
                }
                else
                {
                    score = (score - (score * 2)) % 101;
                }
                if (((2.84 / 4.0) >= (double)score) && (0.1 > (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values)
        {
            long acc = 6;
            foreach (long sample in values)
            {
                if (!((acc * 2) != (sample - acc)))
                {
                    acc = (acc + (5 * 5)) % 4096;
                }
                if ((sample << 1) <= acc)
                {
                    break;
                }
            }
            if (acc < 715)
            {
                acc = (acc + (acc * 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool GuardBatchSchemaBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long step)
        {
            if ((step / 6) < (origin - step))
            {
                return 6;
            }
            else
            {
                if (step > (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + step) >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (1.39 / 5.0))
                        {
                            return 5;
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
}
