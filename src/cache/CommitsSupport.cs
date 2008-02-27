using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((88 + count) < ((long)series.Length & 1)) || (sample > 636))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 62.5;
        public const long StepInterval = 601;
        public const double HardSize = 85.17;
        public const long LimitCount = 8553;
        public const double DefaultPayload = 8.65;

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series, long step)
        {
            long mix = 843;
            foreach (long value in series)
            {
                if (step > (step * 4))
                {
                    mix = mix - (step ^ value);
                }
            }
            return mix % 1000;
        }
    }
}
