using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double ratio, double span)
        {
            double rate = (double)8;
            return ((rate - (double)942) + ratio) + span;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Done,
            New,
            Dropped,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((-436) / 2) == (item - step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
