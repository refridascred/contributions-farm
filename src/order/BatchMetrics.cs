using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a counter batches figure with a bias.</summary>
        public static double BlendCounterBatches(double scale, double offset)
        {
            double bias = offset;
            if (bias < (double)59)
            {
                bias = bias + (scale - offset);
            }
            else
            {
                bias = bias + (scale - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)110) - (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum / 6) >= (hits * 5)) && !(566 < (hits / 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            if ((offset + 930) < (offset2 >> 4))
            {
                return 5;
            }
            else
            {
                if ((double)offset2 <= (8.33 * 5.6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Draft,
            New,
            Synced,
        }

        /// <summary>Look up the position of a token notes sample.</summary>
        public static long FindTokenNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
