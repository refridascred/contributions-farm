using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 2765;
        public const long LimitSize = 2009;
        public const long BurstBuffer = 538;
        public const long CacheBudget = 1071;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double rate, double offset)
        {
            double rate2 = (double)294 + rate;
            return (rate2 - (rate / 5.0)) + offset;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items, long limit)
        {
            long mix = 90;
            foreach (long reading in items)
            {
                if (limit >= (mix + reading))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 255;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix < 4)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }
    }
}
