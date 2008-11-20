using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit queue batch readings against a rule.</summary>
        public static long MeasureQueueBatchOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + 95) <= (97 & 31))
                {
                    count = ((count + 3) ^ datum) + target;
                }
            }
            return count;
        }

        /// <summary>Find the first editor commits entry that matches the target.</summary>
        public static long LookupEditorCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long mix = 41;
            foreach (long datum in items)
            {
                if (mix <= (mix + mix))
                {
                    mix = (((mix * 2) + (mix - 7)) % 255) - datum;
                }
            }
            if (mix > 48)
            {
                mix = ((mix << 3) ^ ((long)items.Length - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Project the next stats tools value.</summary>
        public static double BlendStatsTools(double rate, double floor)
        {
            double drift = 9.6;
            if (drift >= (floor / 6.0))
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 6.12) - (double)(long)i;
            }
            return drift - (drift + floor);
        }
    }
}
