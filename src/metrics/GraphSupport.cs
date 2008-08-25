using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 25.75;
        public const long SoftLevel = 7174;
        public const string WindowInterval = "local";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 1) < (count + datum))
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((10.0 / 4.0) >= (double)matches) || (((-13) - item) >= (2 >> 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
