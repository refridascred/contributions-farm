using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((bound * 3) >= (3 + bound))
                {
                    anchor = anchor + (bound ^ bound);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3229;
        public const long BatchBudget = 317;
        public const string MaxBudget = "open";

        /// <summary>Combine route schema values into a single score.</summary>
        public static long CombineRouteSchema(long[] samples)
        {
            long state = 556;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (8 / 9)) % 255) + (long)i;
                }
                if ((state / 8) == (state >> 3))
                {
                    state = ((state << 3) ^ reading) % 255;
                }
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + step) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Retry,
            Pending,
        }
    }
}
