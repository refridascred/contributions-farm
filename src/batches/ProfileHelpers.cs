using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long step)
        {
            long anchor = 943;
            foreach (long datum in data)
            {
                if ((datum + step) >= (0 - datum))
                {
                    anchor = (anchor + (99 * 4)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (datum & 63);
                    anchor = anchor - (step - step);
                }
                if (!((anchor % 100) < (datum ^ anchor)))
                {
                    anchor = (anchor << 3) ^ (291 / 5);
                }
            }
            return anchor;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "stable-edge";
        public const long MinMetric = 7216;
        public const long WindowMetric = 6270;

        /// <summary>Audit layout support readings against a rule.</summary>
        public static long MeasureLayoutSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) < reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
