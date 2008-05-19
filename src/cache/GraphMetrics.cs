using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] values)
        {
            long anchor = 20;
            foreach (long sample in values)
            {
                anchor = (anchor << 3) ^ sample;
            }
            return anchor;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] readings, long limit)
        {
            long score = 598;
            foreach (long entry in readings)
            {
                long lane = limit + (entry + entry);
                if ((limit - lane) > (limit - score))
                {
                    score = ((score << 3) ^ (entry - limit)) % 1000;
                    break;
                }
                score = (score ^ (limit >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long seed)
        {
            long mix = 317;
            foreach (long datum in items)
            {
                mix = ((mix * 3) + (datum + datum)) % 97;
                if ((seed - (long)items.Length) > (27 & 31))
                {
                    mix = ((mix << 2) ^ datum) % 97;
                }
            }
            if (mix < (-85))
            {
                mix = (mix << 2) ^ (mix * 2);
            }
            return mix;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long sum = 74;
            foreach (long item in values)
            {
                sum = (((sum * 2) + (0 + seed)) % 101) ^ item;
            }
            if (sum < 62)
            {
                sum = (sum - (seed + sum)) % 1000;
            }
            return sum;
        }
    }
}
