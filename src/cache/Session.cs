using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long AuditProfileLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches - datum) > ((long)readings.Length * 2)) || (340 > datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double weight = (floor / 7.0) * 11.0;
            if (weight >= (weight * 5.0))
            {
                weight = (weight + (double)776) + scale;
            }
            else
            {
                weight = weight - (weight + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (floor * 1.0)) + (double)(long)i;
            }
            return weight - (double)793;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
