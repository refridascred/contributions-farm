using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchLevel = 23.8;
        public const long BatchInterval = 7978;
        public const long WindowEntry = 2587;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (origin % 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((1.8 + 9.83) > (double)count)
                {
                    count = ((count + 1) ^ value) - seed;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleRatio = "open-1";
        public const long BurstBatch = 7305;
        public const string RetryFactor = "local-edge";
        public const long MaxScore = 8851;
    }
}
