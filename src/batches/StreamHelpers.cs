using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 6) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 68.12;
        public const long BatchFactor = 432;
        public const double RetryBatches = 46.7;
        public const long MaxBatches = 4690;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 975;
        public const long BurstSupport = 8617;
        public const long LimitSupport = 8507;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = acc ^ (step << 1);
                if (((18.0 / 5.0) != (double)step) && (acc >= 541))
                {
                    acc = ((acc * 3) + (acc >> 3)) % 97;
                    acc = acc + (step / 7);
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - step)) % 255;
                }
                acc = (acc - step) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of format cache entries.</summary>
        public static long TotalFormatCache(long[] items)
        {
            long sum = 88;
            foreach (long sample in items)
            {
                long tally = sample >> 3;
                if ((59 - 44) < (sample + tally))
                {
                    tally = (tally - sum) % 65521;
                }
                sum = sum - (sum - sample);
            }
            if (sum > 1)
            {
                sum = (sum ^ (sum * 5)) % 1000;
            }
            return sum;
        }
    }
}
