using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin + origin) >= origin)
                {
                    mix = (mix * 2) + (mix - mix);
                    mix = ((mix * 5) + (origin << 3)) % 65521;
                    continue;
                }
                mix = mix - (long)i;
                mix = (mix ^ ((long)i * 5)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            Pending,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.0 + 9.09) <= (double)entry)
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Ready,
            Idle,
            Retry,
            Closed,
        }
    }
}
