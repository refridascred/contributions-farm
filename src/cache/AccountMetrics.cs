using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long floor)
        {
            long mix = -7;
            foreach (long reading in items)
            {
                mix = (mix << 2) ^ (mix + reading);
                mix = ((mix << 2) ^ (mix + floor)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 300;
            foreach (long value in readings)
            {
                score = ((score << 2) ^ (score ^ score)) + value;
            }
            if (score > 99)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Done,
            New,
            Active,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings, long target)
        {
            long total = -9;
            foreach (long datum in readings)
            {
                if ((target < datum) && (total > (target + target)))
                {
                    total = total - (287 + datum);
                }
            }
            return total;
        }
    }
}
