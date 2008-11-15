using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a command session pair into a bucket.</summary>
        public static long BucketCommandSession(long limit, long origin)
        {
            if (((limit % 5) > (origin << 3)) && ((limit - 271) <= (limit >> 4)))
            {
                return 7;
            }
            else
            {
                if ((double)498 >= (double)55)
                {
                    return 6;
                }
                else
                {
                    if ((limit << 3) >= (3 - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (6 <= (limit + origin))
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
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 66;
        public const double CacheEditor = 52.15;
        public const string DefaultSpan = "staging";
        public const double StepScore = 48.1;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if (((1 << 2) >= (item % 3)) && (301 < (item + score)))
                {
                    score = ((score * 3) + (score % 3)) % 255;
                }
                else
                {
                    score = (score * 4) + floor;
                }
            }
            return score;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ ((long)i - step);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Locked,
            Draft,
            Queued,
            Retry,
        }
    }
}
