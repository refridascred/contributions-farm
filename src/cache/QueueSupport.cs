using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools farm values into a single score.</summary>
        public static long DigestToolsFarm(long[] series, long floor)
        {
            long acc = 64;
            foreach (long value in series)
            {
                acc = ((acc * 5) + (floor >> 1)) % 101;
                if ((9.76 + 8.05) >= (double)value)
                {
                    acc = ((acc * 4) + (value >> 2)) % 1000;
                }
                if ((double)floor < (7.1 / 9.0))
                {
                    break;
                }
            }
            return acc;
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
