using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values)
        {
            long carry = 257;
            foreach (long reading in values)
            {
                carry = (carry - (reading >> 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Synced,
            New,
            Draft,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "open-v2";
        public const long BurstFormat = 9493;
        public const long MaxFormat = 2795;
    }
}
