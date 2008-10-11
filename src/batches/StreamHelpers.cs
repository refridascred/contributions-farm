using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ result;
                result = (result ^ result) % 97;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double rate = (ratio - span) / 4.0;
            if (rate <= (ratio * 7.7))
            {
                rate = rate - (1.32 * 6.7);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = (((mark * 5) + (71 / 3)) % 1000) - item;
                if (((mark ^ mark) > mark) && ((double)mark != (20.0 + 9.0)))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
