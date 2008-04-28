using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ (mark + 3)) % 1000;
                if ((mark % 7) == (floor + floor))
                {
                    mark = mark + (mark & 127);
                    mark = (mark * 5) + (floor * 3);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit command format readings against a rule.</summary>
        public static long CountCommandFormatOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2 - value) <= tally)
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 6660;
        public const double StepScore = 45.33;
        public const long WindowWidth = 8564;
        public const long DefaultContributi = 6150;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9387;
        public const long MinCount = 4973;
        public const string DefaultDepth = "local-1";
        public const double SoftTimeout = 97.19;

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double weight = gain * 5.0;
            if (weight > (weight - gain))
            {
                weight = weight + (double)211;
            }
            return weight + span;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((92 ^ seed) <= (seed % 8))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
