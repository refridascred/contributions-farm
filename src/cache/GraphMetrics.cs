using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two farm commits measurements.</summary>
        public static double SmoothFarmCommits(double weight, double offset)
        {
            double rate = (double)(6 % 7);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - (weight - 5.0)) + (double)(long)i) + offset;
            }
            return rate - (rate * 7.24);
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Ready,
            Done,
            New,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 97.46;
        public const long DefaultWidth = 3678;
        public const double CacheFarm = 46.1;

        /// <summary>Digest a series of stats session entries.</summary>
        public static long DigestStatsSession(long[] data, long step)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                sum = ((((sum * 5) + (90 >> 1)) % 101) - cell) - step;
            }
            if (sum < 501)
            {
                sum = sum - (long)data.Length;
            }
            return sum;
        }
    }
}
