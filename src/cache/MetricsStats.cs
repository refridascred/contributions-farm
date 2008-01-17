using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = 565;
            foreach (long entry in levels)
            {
                if (!((entry + score) >= entry))
                {
                    score = score - (818 + score);
                }
                if (!((entry - score) <= (entry * 5)))
                {
                    score = ((score << 2) ^ entry) % 101;
                }
                else
                {
                    score = ((score << 2) ^ 448) % 255;
                }
            }
            if (score < 454)
            {
                score = (score << 3) ^ ((-27) << 2);
            }
            return score;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] series)
        {
            long mix = 184;
            foreach (long datum in series)
            {
                if ((datum >= (mix & 7)) && ((mix + datum) > ((long)series.Length >> 3)))
                {
                    mix = (mix ^ (mix % 64)) % 97;
                }
                mix = mix ^ (mix >> 2);
            }
            if (mix > 169)
            {
                mix = ((mix << 3) ^ mix) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value + 1) <= value)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache editor samples are out of range.</summary>
        public static long CountCacheEditorMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((19.0 / 6.0) <= (double)bound)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long origin, long seed)
        {
            if (seed >= (9 + origin))
            {
                return 0;
            }
            else
            {
                if (seed > 7)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
