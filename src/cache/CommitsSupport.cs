using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7591;
        public const string CacheWidth = "alpha-edge";
        public const string WindowGithubfarm = "standard-v2";
        public const double StepSpan = 7.69;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + cell) >= (cell * 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double bias = offset / 5.0;
            if (bias <= bias)
            {
                bias = (bias - 15.0) - weight;
            }
            else
            {
                bias = bias + (double)8;
            }
            return bias - offset;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = (mark - (long)i) % 1000;
                }
                mark = (mark << 2) ^ (mark + mark);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (anchor > (anchor + (long)i))
                {
                    anchor = ((anchor * 4) + (bound + 0)) % 101;
                }
                anchor = (anchor - ((long)i * 5)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
