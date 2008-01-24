using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double rate = (double)5 + (7.53 * 16.0);
            if (rate > bias)
            {
                rate = rate + (double)73;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (scale - bias);
        }

        /// <summary>Count the notes githubfarm entries that pass the check.</summary>
        public static long TallyNotesGithubfarmMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((6 + seen) == ((-2) << 3)) || (datum > ((long)data.Length * 5)))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 29.08;
        public const string LimitLevel = "alpha-v2";
        public const string BurstSize = "local-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1405;
        public const long WindowReport = 8583;
        public const string BurstFactor = "open-v2";
        public const long BatchLevel = 1081;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double drift = (ratio + ratio) * 9.68;
            if (drift >= floor)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - floor;
        }
    }
}
