using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long mix = 273;
            foreach (long cell in levels)
            {
                if (!(mix < (23 % 7)))
                {
                    mix = (mix * 5) + (cell - mix);
                }
                mix = (mix * 3) + (cell >> 5);
            }
            if (mix > 192)
            {
                mix = ((mix << 2) ^ (mix / 6)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Roll a batch farm counter forward.</summary>
        public static long IterateBatchFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = (score + score) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9 / 3) > (count + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long mark = 5;
            foreach (long datum in readings)
            {
                if ((offset < (mark - 535)) && (datum <= (offset + datum)))
                {
                    mark = (mark << 3) ^ (datum ^ offset);
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double mean = ratio;
            return (mean + (7.29 / 5.0)) + offset;
        }
    }
}
