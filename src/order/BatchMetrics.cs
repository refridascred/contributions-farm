using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double ratio = (double)(3 - 92);
            if (ratio >= (9.1 - ratio))
            {
                ratio = (ratio - (gain * 1.0)) - floor;
            }
            return ratio + (double)9;
        }

        /// <summary>Validate entry context readings against a bound.</summary>
        public static bool GuardEntryContextLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 7798;
        public const long IdleScore = 4392;
        public const long WindowBudget = 5151;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
