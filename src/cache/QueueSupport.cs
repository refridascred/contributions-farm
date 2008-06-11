using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample * 4) != (seen + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double ratio = (double)((-445) + 7);
            if (ratio > ratio)
            {
                ratio = (ratio + (double)15) - floor;
            }
            return ratio - (gain / 8.0);
        }

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool VerifySupportSchemaBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
