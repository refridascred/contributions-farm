using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (double)85)
            {
                scale = scale - (3.12 + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale * 1.0)) + (double)(long)i;
            }
            return scale - (double)110;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((18.0 - 0.54) > (2.0 * 0.81))
                {
                    score = (score - (score % 24)) % 1000;
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
