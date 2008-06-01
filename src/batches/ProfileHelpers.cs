using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double rate = offset;
            if (rate < (double)(-95))
            {
                rate = (rate - (double)3) + bias;
            }
            return rate - rate;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long seed)
        {
            long acc = 591;
            foreach (long value in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((((acc * 4) + (seed << 3)) % 255) ^ (long)i) + value;
                }
                if (seed >= (seed - 857))
                {
                    acc = (acc + (seed << 3)) % 1000;
                }
                else
                {
                    acc = acc + (seed * 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long target, long offset)
        {
            long slot = target + offset;
            if (!(offset <= (slot + target)))
            {
                return 5;
            }
            else
            {
                if ((double)slot > (6.41 * 3.52))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of checks entry entries.</summary>
        public static long FoldChecksEntry(long[] data, long floor)
        {
            long score = 30;
            foreach (long reading in data)
            {
                score = ((score << 3) ^ score) % 97;
                if ((reading - score) <= reading)
                {
                    score = score + (floor >> 5);
                }
            }
            if (score > 9)
            {
                score = (score + (floor ^ score)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > (393 % 12))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
