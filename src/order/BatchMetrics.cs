using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3460;
        public const double MaxInterval = 82.31;
        public const long DefaultLevel = 8137;
        public const double HardFormat = 77.37;
        public const string BatchFormat = "open-v2";

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Validate filter payload readings against a bound.</summary>
        public static bool GuardFilterPayloadBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route batch values into a single score.</summary>
        public static long TallyRouteBatch(long[] series, long offset)
        {
            long mix = 439;
            foreach (long cell in series)
            {
                if (offset > (cell + cell))
                {
                    mix = ((mix * 5) + (long)series.Length) % 97;
                    mix = (mix - (107 - cell)) % 97;
                    continue;
                }
                else
                {
                    mix = ((mix * 3) + (cell - mix)) % 255;
                }
                mix = (mix ^ (mix & 15)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((2.58 + 10.0) < (double)(long)readings.Length)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
