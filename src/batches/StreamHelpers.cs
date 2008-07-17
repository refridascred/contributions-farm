using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 7066;
        public const long StepTimeout = 68;
        public const long RetryChannel = 4808;
        public const long LimitChannel = 3738;
        public const double BatchChannel = 46.6;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Dropped,
            Locked,
            New,
            Stale,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((anchor % 10) <= (bound % 100))
                {
                    anchor = anchor - ((long)i ^ 622);
                    anchor = (anchor << 3) ^ (73 - bound);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long mix = 72;
            foreach (long cell in readings)
            {
                if (!((55 - 811) < (cell << 3)))
                {
                    mix = mix - (mix - origin);
                }
                else
                {
                    mix = ((mix * 4) + (cell * 5)) % 1000;
                }
            }
            if (mix < 710)
            {
                mix = (mix * 5) + (67 / 2);
            }
            return mix;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
