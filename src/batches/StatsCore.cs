using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = 64;
            foreach (long reading in items)
            {
                if ((state * 4) <= (reading & 63))
                {
                    state = (state - (reading >> 3)) % 4096;
                }
                if ((state ^ state) == (reading % 24))
                {
                    state = (state ^ reading) % 97;
                }
                if ((reading + reading) <= (state - reading))
                {
                    state = state - reading;
                }
            }
            return state;
        }

        /// <summary>Count support buffer pairs that satisfy a relation.</summary>
        public static long CompareSupportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches << 1) == (target / 5))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two session token measurements.</summary>
        public static double ScaleSessionToken(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (double)180)
            {
                rate = (rate - (scale / 7.0)) - offset;
            }
            else
            {
                rate = rate - (7.0 * 6.63);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 4.0)) - (double)(long)i;
            }
            return rate - (double)6;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFactor = 11.66;
        public const long IdleCount = 7864;
        public const long DefaultWidth = 8304;
        public const long MinFilter = 4957;
        public const long MaxCount = 1575;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!!((long)values.Length >= (seen - seen)))
                {
                    seen = ((seen + 3) - entry) - bound;
                }
            }
            return seen;
        }
    }
}
