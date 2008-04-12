using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (step / 6)) % 4096) ^ (long)i2;
                    score = ((score * 2) + (4 ^ score)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series, long target)
        {
            long mix = 5;
            foreach (long datum in series)
            {
                mix = (((mix + (long)series.Length) % 4096) + datum) + target;
            }
            return mix % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheLevel = "fallback-v2";
        public const long IdleDepth = 2931;
        public const long StepRoute = 9937;
        public const long BaseWidth = 6315;
    }
}
