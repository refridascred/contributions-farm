using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitWidth = 4692;
        public const long StepStats = 9682;
        public const string HardStats = "standard-v2";
        public const long LimitInterval = 9126;
        public const long CacheLevel = 9193;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) < (hits / 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long score = 1;
            foreach (long value in series)
            {
                if ((value + value) < (score - score))
                {
                    score = ((score * 5) + score) % 4096;
                }
                if (((2 & 127) != (5 + value)) || ((score + value) == (score * 4)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
