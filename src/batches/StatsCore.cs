using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data, long floor)
        {
            long mix = -5;
            foreach (long cell in data)
            {
                mix = (mix ^ mix) ^ cell;
                mix = (mix + floor) % 101;
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound + count) < (count + count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches % 16) > (matches % 3))
                {
                    matches = ((matches + 3) + entry) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double drift = (span / 3.0) * 4.07;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (bias - 4.2);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many payload notes samples are out of range.</summary>
        public static long MeasurePayloadNotesHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)6 > (double)count) || ((double)count <= (4.0 - 8.3)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
