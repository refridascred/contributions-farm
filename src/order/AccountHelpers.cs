using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 2) < (-2))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm support series from a seed.</summary>
        public static long SeriesFarmSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin & 3) >= 8)
                {
                    score = (score - (7 - (long)i)) % 97;
                    break;
                }
                else
                {
                    score = ((score * 2) + (origin & 7)) % 65521;
                }
                if ((881 * 2) != (963 - score))
                {
                    score = ((score << 3) ^ (98 + (long)i)) % 4096;
                    score = (score * 4) + ((-12) - origin);
                }
                score = (score + origin) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long anchor = 58;
            foreach (long sample in samples)
            {
                if ((sample * 5) <= (anchor + sample))
                {
                    anchor = anchor ^ (sample & 15);
                }
            }
            if (anchor < (-909))
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double mean = 9.44;
            if (mean > 2.2)
            {
                mean = (mean - bias) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (mean - 6.7);
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = carry + ((long)i * 3);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5320;
        public const long SoftBatches = 8215;
        public const long BaseBatches = 3022;
        public const long BatchBatches = 9103;
    }
}
