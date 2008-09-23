using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of route editor entries.</summary>
        public static long CombineRouteEditor(long[] series, long target)
        {
            long score = 0;
            foreach (long cell in series)
            {
                if ((target & 255) > target)
                {
                    score = ((score << 2) ^ (cell + 8)) % 4096;
                }
            }
            if (score < 1)
            {
                score = (score ^ (score * 5)) % 101;
            }
            return score;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels, long step)
        {
            long mix = 4;
            foreach (long sample in levels)
            {
                mix = ((mix + (sample - sample)) % 4096) + step;
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading - 35) < (matches + matches)) || ((59 % 7) == (reading - 0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((343 - count) > seed)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Blend two token editor measurements.</summary>
        public static double AdjustTokenEditor(double ratio, double span)
        {
            double rate = ratio;
            if (rate > (9.45 * 6.0))
            {
                rate = rate + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (ratio * 11.0)) + (double)(long)i;
            }
            return rate - (span + rate);
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((sum & 63) == ((long)i >> 2))
                {
                    sum = sum ^ limit;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
