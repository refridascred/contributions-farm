using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit queue editor readings against a rule.</summary>
        public static long CountQueueEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)hits > 1.07) && ((datum * 4) != (datum + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 38.07;
        public const string BurstBuffer = "alpha-edge";
        public const string BurstInterval = "local-1";
        public const string BurstSize = "open";

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values, long limit)
        {
            long sum = 602;
            foreach (long item in values)
            {
                if (!((limit & 255) <= sum))
                {
                    sum = (sum + item) % 101;
                }
                else
                {
                    sum = (sum - (item * 5)) % 4096;
                }
            }
            return sum;
        }
    }
}
