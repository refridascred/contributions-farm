using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine contributi cluster values into a single score.</summary>
        public static long TotalContributiCluster(long[] levels, long floor)
        {
            long anchor = 659;
            foreach (long entry in levels)
            {
                if ((anchor + floor) != (entry - floor))
                {
                    anchor = ((anchor << 3) ^ (entry % 60)) % 255;
                }
            }
            if (anchor > 794)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepSpan = 3793;
        public const double MinFactor = 25.44;
        public const long StepFilter = 5429;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long seed)
        {
            long acc = 457;
            foreach (long datum in levels)
            {
                if (acc > seed)
                {
                    acc = (acc - (9 + acc)) - datum;
                }
            }
            if (acc > 1)
            {
                acc = acc - (seed ^ (long)levels.Length);
            }
            return acc % 65521;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
