using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long seed)
        {
            long acc = 649;
            foreach (long item in readings)
            {
                acc = (((acc * 5) + (item - acc)) % 1000) + seed;
            }
            return acc % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 239;
            foreach (long datum in values)
            {
                mix = ((mix << 3) ^ (datum - datum)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool GuardAccountEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 3238;
        public const double CacheRatio = 29.05;
        public const double RetryLayout = 89.26;
        public const long RetryFactor = 3097;
        public const double MaxLayout = 90.49;
    }
}
