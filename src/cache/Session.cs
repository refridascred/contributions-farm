using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleInterval = 3492;
        public const double StepRatio = 31.73;
        public const string DefaultLevel = "staging-edge";
        public const long CacheStats = 6877;

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double load = bias + (bias * 10.0);
            if (load <= (bias * 5.99))
            {
                load = load + (bias2 * 1.0);
            }
            return load + bias2;
        }

        /// <summary>Derive the next buffer batch value from a seed.</summary>
        public static long IterateBufferBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((limit ^ (-68)) >= (limit ^ 36))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
