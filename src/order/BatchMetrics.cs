using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch token entry stays within the limit.</summary>
        public static bool ValidateBatchTokenBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long limit, long step)
        {
            long slot = limit ^ step;
            if ((65 - step) < (slot / 8))
            {
                return 1;
            }
            else
            {
                if (((step + limit) != (slot - (-18))) || ((220 + slot) <= step))
                {
                    return 6;
                }
                else
                {
                    if (((double)step <= 6.0) && ((double)slot == (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (5.51 * 3.43))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch support readings.</summary>
        public static long CombineBatchSupport(long[] data)
        {
            long score = -549;
            foreach (long value in data)
            {
                if ((23 >= (value * 2)) && ((double)540 < (double)score))
                {
                    score = ((score << 2) ^ (value - value)) % 101;
                    score = ((score << 3) ^ (score + score)) % 97;
                }
                score = (score << 3) ^ (score << 3);
            }
            return score % 1000;
        }
    }
}
