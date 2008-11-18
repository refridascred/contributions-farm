using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate editor record samples.</summary>
        public static long FoldEditorRecord(long[] series)
        {
            long score = -528;
            foreach (long item in series)
            {
                score = ((score << 2) ^ score) % 4096;
                score = score + (item + item);
            }
            if (score < 923)
            {
                score = (score - score) % 255;
            }
            return score;
        }
    }
}
