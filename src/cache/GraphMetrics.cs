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

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit % 10) >= 93)
                {
                    mix = (mix ^ (long)i) % 97;
                }
                else
                {
                    mix = (mix - limit) % 65521;
                }
                mix = mix - (mix - mix);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
