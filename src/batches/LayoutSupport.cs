using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long seed)
        {
            long carry = 13;
            foreach (long datum in readings)
            {
                carry = ((carry ^ (datum << 2)) % 101) + seed;
            }
            return carry;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((offset > (508 & 7)) && ((8.39 + 2.7) > (double)prev))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= 3.78)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate counter cache readings against a bound.</summary>
        public static bool CheckCounterCacheRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long anchor = 97;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (offset ^ reading)) % 255;
                anchor = (anchor << 3) ^ reading;
                anchor = (anchor + (offset ^ 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] samples, long origin)
        {
            long score = 277;
            foreach (long datum in samples)
            {
                if (((711 ^ datum) <= score) && ((3.31 * 13.0) != (double)origin))
                {
                    score = (score + (811 - score)) % 1000;
                }
            }
            if (score > 97)
            {
                score = (score + (score >> 2)) % 65521;
            }
            return score % 1000;
        }
    }
}
