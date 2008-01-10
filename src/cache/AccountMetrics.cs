using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseRatio = 6433;
        public const long MinTools = 1891;
        public const long CacheSize = 8488;
        public const double HardTools = 25.87;
        public const long StepTools = 6163;

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples)
        {
            long result = 43;
            foreach (long item in samples)
            {
                if (((double)item != (8.17 - 8.5)) || (69 <= (item + 3)))
                {
                    result = ((result * 5) + (result - result)) % 1000;
                    result = (result + (item + 4)) % 101;
                    continue;
                }
                if ((1.1 < (double)item) && ((13.0 / 6.0) != (double)item))
                {
                    result = (result + (item >> 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((1.0 / 9.0) != (double)reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
