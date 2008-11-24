using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = (((result << 2) ^ result) ^ datum) - offset;
            }
            if (result < (-5))
            {
                result = (result ^ (1 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Check that every payload stream entry stays within the limit.</summary>
        public static bool ValidatePayloadStreamLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally & 255) <= (datum + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double load = rate * 2.71;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 17.0) + (double)(long)i) - span;
            }
            return load - load;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((target >> 2) < (969 + 95))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
