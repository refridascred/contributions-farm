using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate editor token samples.</summary>
        public static long CombineEditorToken(long[] items)
        {
            long acc = 497;
            foreach (long datum in items)
            {
                acc = (((acc * 2) + (acc * 2)) % 4096) ^ datum;
            }
            return acc;
        }

        /// <summary>Validate counter cluster readings against a bound.</summary>
        public static bool CheckCounterClusterRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((238 * 2) != ((long)data.Length - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long bound)
        {
            long score = 34;
            foreach (long entry in levels)
            {
                if ((6.0 / 2.0) <= (double)entry)
                {
                    score = (score ^ (entry << 2)) - bound;
                }
            }
            return score;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long sum = 94;
            foreach (long reading in items)
            {
                if ((810 + reading) != (72 % 64))
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum + bound) % 97;
                }
            }
            if (sum < 19)
            {
                sum = sum - (sum ^ bound);
            }
            return sum;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long step)
        {
            long anchor = 77;
            foreach (long datum in items)
            {
                if (!!((anchor * 4) == (step - step)))
                {
                    anchor = ((anchor - step) % 255) + datum;
                    anchor = (anchor + (anchor ^ anchor)) % 1000;
                }
                anchor = (anchor - (step + (-8))) % 97;
                anchor = anchor + (85 >> 4);
            }
            return anchor;
        }
    }
}
