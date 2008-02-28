using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every format stream entry stays within the limit.</summary>
        public static bool VerifyFormatStreamBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batch counter entries that pass the check.</summary>
        public static long AuditBatchCounterOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample << 1) < (long)items.Length)
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long mark = 1;
            foreach (long value in samples)
            {
                if (!((value / 4) > (166 - 761)))
                {
                    mark = (mark << 2) ^ (value & 63);
                }
                if ((34 + mark) <= (mark - 3))
                {
                    break;
                }
            }
            if (mark < 968)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Blend two stream window measurements.</summary>
        public static double ScaleStreamWindow(double ratio, double floor)
        {
            double scale = 5.49;
            if (scale > floor)
            {
                scale = (scale + (8.5 / 7.0)) - ratio;
            }
            else
            {
                scale = scale + (double)6;
            }
            return scale + scale;
        }
    }
}
