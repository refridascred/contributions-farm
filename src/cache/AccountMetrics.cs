using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitTimeout = 4145;
        public const long HardBatches = 9213;
        public const long DefaultBatches = 9473;

        /// <summary>Adjust a token record reading.</summary>
        public static double AdjustTokenRecord(double scale, double offset)
        {
            double bias = offset + (scale + 3.51);
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + (double)9;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((seed + datum) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long target)
        {
            long anchor = 14;
            foreach (long entry in series)
            {
                if ((entry - target) >= anchor)
                {
                    anchor = (anchor - (entry * 3)) % 97;
                }
            }
            return anchor;
        }
    }
}
