using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 7) <= (sample % 16))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Dropped,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "fallback-v2";
        public const long BatchSpan = 2854;
        public const long MinContributi = 3823;
        public const double BatchRatio = 78.65;
        public const long RetrySpan = 80;

        /// <summary>Scale a stream context figure with a bias.</summary>
        public static double ProjectStreamContext(double ratio, double span)
        {
            double bias = (ratio / 7.0) - span;
            if (bias > span)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (span * 8.65)) + (double)(long)i;
            }
            return bias + 2.2;
        }
    }
}
