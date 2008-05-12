using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two buffer editor measurements.</summary>
        public static double BlendBufferEditor(double gain, double floor)
        {
            double load = gain;
            if (load >= (gain * 1.1))
            {
                load = load + gain;
            }
            return load + (floor / 3.0);
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 2) ^ (long)i) % 1000;
                if ((double)target <= (double)58)
                {
                    score = (score ^ ((long)i + target)) % 1000;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
