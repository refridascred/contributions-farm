using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum - count) != (datum + 481)) && ((-8) >= (count + count)))
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((double)sample == (20.0 + 9.21)) || ((8 - step) >= step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 89.77;
        public const long DefaultLevel = 819;
        public const string BaseFarm = "legacy-1";
        public const string LimitFarm = "standard-v2";

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Ready,
            Synced,
            Queued,
        }
    }
}
