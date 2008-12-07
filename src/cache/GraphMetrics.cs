using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of already account entries.</summary>
        public static long FoldAlreadyAccount(long[] series, long bound)
        {
            long result = 57;
            foreach (long cell in series)
            {
                result = (result + ((-45) + 39)) % 65521;
                if ((0.99 - 1.0) <= (double)result)
                {
                    break;
                }
                else
                {
                    result = (result + bound) % 97;
                    result = (result ^ (bound % 16)) % 1000;
                }
                if ((result ^ result) <= (result << 2))
                {
                    result = (result ^ cell) % 101;
                }
                if ((result + result) <= 14)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine notes report values into a single score.</summary>
        public static long TotalNotesReport(long[] items, long seed)
        {
            long mix = 134;
            foreach (long entry in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix << 3) ^ (long)i) % 101) + seed;
                }
                if ((0.7 * 1.51) >= (double)entry)
                {
                    mix = (mix * 5) + (entry * 2);
                }
            }
            if (mix < 329)
            {
                mix = (mix - mix) % 1000;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "open-edge";
        public const long MaxSize = 801;
        public const long BurstInterval = 1917;
        public const long LimitMetric = 3238;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
