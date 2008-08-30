using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long target)
        {
            long lane = bound + target;
            if ((5.0 <= (double)lane) && (target < (lane << 3)))
            {
                return 5;
            }
            else
            {
                if (bound <= (target + bound))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings)
        {
            long mark = 6;
            foreach (long sample in readings)
            {
                if (!((double)sample >= (12.0 - 5.7)))
                {
                    mark = (mark - mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor & 1) <= floor)
                {
                    mark = ((mark * 5) + (602 + floor)) % 4096;
                    mark = (mark + (mark ^ mark)) % 97;
                }
                else
                {
                    mark = mark ^ (mark % 3);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long mark = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (mark + (long)i)) % 97;
                }
                mark = mark ^ (entry + origin);
            }
            return mark % 65521;
        }

        /// <summary>Classify a editor profile pair into a bucket.</summary>
        public static long RankEditorProfile(long bound, long offset)
        {
            if ((bound << 1) >= (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((bound % 8) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound / 9) < offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 5) <= (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
