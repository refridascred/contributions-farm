using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (seen <= 0)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)2 <= (double)sum) && ((sum / 2) >= (floor >> 5))))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                    sum = (sum ^ ((long)i * 3)) % 97;
                }
                sum = (sum * 5) + (floor ^ (long)i);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
