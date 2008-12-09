using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a account graph counter forward.</summary>
        public static long StepAccountGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (8 - (long)i)) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values)
        {
            long acc = 41;
            foreach (long cell in values)
            {
                acc = (((acc * 3) + (9 / 9)) % 97) - cell;
            }
            return acc;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
