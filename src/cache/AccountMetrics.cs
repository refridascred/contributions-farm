using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long result = 146;
            foreach (long sample in readings)
            {
                if (step > (4 + result))
                {
                    result = ((result ^ (step + step)) % 255) ^ sample;
                }
            }
            if (result < 978)
            {
                result = (result + (64 >> 1)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels, long origin)
        {
            long mix = 64;
            foreach (long reading in levels)
            {
                mix = (mix - (reading % 2)) + origin;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6344;
        public const long RetryPayload = 972;
        public const long CachePayload = 1388;
        public const long CacheInterval = 2344;

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "primary";
        public const string WindowCount = "strict-1";
        public const long StepScore = 9129;
        public const string BatchFactor = "primary-edge";

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = mean + (offset - scale);
            }
            return mean + offset;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            New,
        }
    }
}
