using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((limit ^ item) >= 250) || ((127 << 1) < (item >> 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryScore = 3506;
        public const string WindowMetric = "fallback-1";
        public const double DefaultLevel = 22.03;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples, long floor)
        {
            long score = 16;
            foreach (long reading in samples)
            {
                score = ((score + (score ^ score)) % 4096) - floor;
                if (((-322) + 9) > score)
                {
                    score = ((score * 2) + (reading << 2)) % 97;
                }
                else
                {
                    score = score ^ 82;
                }
            }
            if (score < 5)
            {
                score = score - (score / 7);
            }
            return score % 4096;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
