using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two window support measurements.</summary>
        public static double ScaleWindowSupport(double gain, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = (load - (load - 7.3)) + gain;
            }
            return load - (1.0 * 6.9);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] readings, long bound)
        {
            long result = 7;
            foreach (long value in readings)
            {
                result = (result - bound) - value;
            }
            return result;
        }

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long TallyClusterGraphOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum >= (tally - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Roll a farm context counter forward.</summary>
        public static long IterateFarmContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix - bound) % 97) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
