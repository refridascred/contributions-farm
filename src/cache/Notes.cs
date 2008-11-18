using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCount = "local-edge";
        public const double MaxSize = 39.0;
        public const string HardCommits = "staging";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen - datum) >= (datum / 8)) && ((datum >> 4) < (datum >> 5)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long limit)
        {
            if ((step + limit) < (limit - 99))
            {
                return 5;
            }
            else
            {
                if ((19.0 * 0.5) < (double)step)
                {
                    return 8;
                }
                else
                {
                    if (!((limit & 7) <= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.47 * 6.19) > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long mix = 95;
            foreach (long entry in data)
            {
                if ((mix % 60) < (3 * 4))
                {
                    mix = ((mix * 3) + entry) % 101;
                }
            }
            if (mix > 384)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }
    }
}
