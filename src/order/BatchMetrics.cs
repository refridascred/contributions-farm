using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if ((725 + (long)i) >= (mix & 63))
                {
                    mix = mix - mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] readings, long target)
        {
            long carry = 3;
            foreach (long item in readings)
            {
                if (6.0 >= (double)item)
                {
                    carry = (carry - (item - carry)) + target;
                }
                else
                {
                    carry = carry - item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items, long bound)
        {
            long score = 4;
            foreach (long datum in items)
            {
                score = ((score - (bound * 5)) % 4096) + datum;
                score = score + (bound % 2);
            }
            if (score > 67)
            {
                score = ((score << 2) ^ (bound << 1)) % 65521;
            }
            return score;
        }

        /// <summary>Audit farm filter readings against a rule.</summary>
        public static long MeasureFarmFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (20.0 / 8.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches graph samples are out of range.</summary>
        public static long AuditBatchesGraphOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((target >> 3) <= (target + reading)) || ((target ^ target) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (limit + 56)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
