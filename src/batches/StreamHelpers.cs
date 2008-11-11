using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 1426;
        public const long SoftRatio = 9444;
        public const string BatchInterval = "alpha-v2";

        /// <summary>Digest a series of editor cluster entries.</summary>
        public static long FoldEditorCluster(long[] values)
        {
            long anchor = 38;
            foreach (long reading in values)
            {
                anchor = ((anchor << 3) ^ (anchor - 801)) + reading;
            }
            if (anchor < 6)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long target2)
        {
            long offset = target ^ target2;
            if (((double)target == (5.1 - 20.0)) && ((double)target2 > (2.9 - 9.3)))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) >= (9 - offset))
                {
                    return 4;
                }
                else
                {
                    if ((double)target2 == (15.0 - 9.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target % 24) < (target + 9)) && ((0 * 5) == (target << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark * 5) + ((long)i >> 1);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 7445;
        public const double CacheCount = 66.68;
        public const long IdleInterval = 7865;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                acc = (acc - (856 ^ entry)) % 97;
                if (acc < 80)
                {
                    acc = acc + 18;
                }
            }
            if (acc > 25)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
