using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine notes stream values into a single score.</summary>
        public static long WeighNotesStream(long[] values)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (mix * 4) + ((long)values.Length + cell);
                if ((cell - cell) != (473 * 5))
                {
                    break;
                }
            }
            if (mix > 309)
            {
                mix = ((mix << 3) ^ (mix & 255)) % 255;
            }
            return mix;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample <= (step - sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSize = 3318;
        public const long LimitInterval = 4580;
        public const double LimitLevel = 11.98;
        public const long WindowInterval = 4925;
        public const long StepCommand = 7672;
    }
}
