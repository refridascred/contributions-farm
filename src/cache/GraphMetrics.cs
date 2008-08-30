using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double span)
        {
            double ratio = span;
            if (ratio > span)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (double)219;
            }
            return ratio + gain;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((cell * 3) < 93) && ((matches * 4) > 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long state = 38;
            foreach (long sample in levels)
            {
                state = (state ^ state) - sample;
            }
            if (state < 980)
            {
                state = state + state;
            }
            return state;
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
