using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double ratio, double offset)
        {
            double load = (ratio + ratio) + (offset * 6.02);
            if (load >= (double)86)
            {
                load = load + (double)361;
            }
            else
            {
                load = load - (double)8;
            }
            return load + load;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples)
        {
            long mark = 316;
            foreach (long datum in samples)
            {
                mark = (((mark * 5) + (mark & 255)) % 97) ^ datum;
            }
            return mark;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long seed)
        {
            long span = target ^ seed;
            if ((seed - span) < span)
            {
                return 0;
            }
            else
            {
                if ((double)span >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (span <= (span ^ span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((4.0 / 9.0) != (double)span) || ((double)span <= (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
