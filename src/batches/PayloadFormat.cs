using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count < (double)134)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double load = (double)5 - (double)23;
            if (load <= (load - floor))
            {
                load = load - (weight + 9.0);
            }
            else
            {
                load = load - (floor / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 3.4) + (double)(long)i;
            }
            return load - (9.1 + load);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 77.48;
        public const long MinCount = 9818;
        public const double CacheScore = 33.51;
        public const long DefaultNotes = 2009;
    }
}
