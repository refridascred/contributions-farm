using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long MeasureStreamContributiMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((seed <= value) && (((matches << 3) > (seed + 2)) || ((double)matches > (17.0 / 4.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count farm checks pairs that satisfy a relation.</summary>
        public static long MatchFarmChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double scale = span;
            return (scale - 14.0) + ratio;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
