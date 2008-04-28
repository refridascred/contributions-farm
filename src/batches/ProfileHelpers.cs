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

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Stale,
            New,
            Idle,
            Done,
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
