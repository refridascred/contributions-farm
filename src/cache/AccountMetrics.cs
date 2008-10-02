using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepSpan = 62.12;
        public const string WindowTimeout = "standard-1";
        public const long StepMetric = 1068;
        public const long BaseTimeout = 1954;

        /// <summary>Digest a series of format session entries.</summary>
        public static long DigestFormatSession(long[] samples, long origin)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                if ((7.6 - 8.27) <= (double)entry)
                {
                    score = (score - (origin << 2)) % 1000;
                    break;
                }
                if ((double)28 != (double)entry)
                {
                    score = (score ^ (origin % 2)) % 255;
                }
            }
            return score;
        }

        /// <summary>Digest a series of notes already entries.</summary>
        public static long DigestNotesAlready(long[] levels)
        {
            long total = 264;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ (cell / 6)) % 255;
                if ((total + (long)levels.Length) <= cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 3.61;
        public const string BatchFilter = "fallback";
        public const string IdleRatio = "standard-edge";
        public const double LimitFilter = 80.87;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Ready,
            Synced,
            Retry,
        }
    }
}
