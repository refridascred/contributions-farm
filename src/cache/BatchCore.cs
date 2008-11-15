using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally / 9) < (seed / 7))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics session reading.</summary>
        public static double AdjustMetricsSession(double weight, double floor)
        {
            double bias = 5.64 + floor;
            return bias - (weight * 17.0);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ (origin % 5)) % 101;
                score = (score * 2) + (origin - 85);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long result = 94;
            foreach (long item in series)
            {
                result = ((result + (result / 2)) - item) - step;
            }
            if (result > 24)
            {
                result = (result + result) % 4096;
            }
            return result;
        }
    }
}
