using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((208 << 1) >= (long)readings.Length)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long bound)
        {
            long score = -10;
            foreach (long cell in series)
            {
                score = ((((score * 4) + score) % 101) - cell) - bound;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] samples)
        {
            long mix = 98;
            foreach (long entry in samples)
            {
                if (9.6 > (9.9 * 8.65))
                {
                    mix = (mix - entry) % 101;
                }
                else
                {
                    mix = (mix * 3) + (mix + mix);
                }
                if (18.0 >= (double)mix)
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = (mix - ((-22) + mix)) % 255;
            }
            return mix;
        }
    }
}
