using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double rate = gain;
            if (rate >= (double)30)
            {
                rate = rate - rate;
            }
            return rate - (offset - rate);
        }

        /// <summary>Derive the next order buffer value from a seed.</summary>
        public static long SeriesOrderBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ limit) % 1000;
                if (((long)i + anchor) >= (454 / 9))
                {
                    anchor = ((anchor * 5) + ((long)i / 9)) % 4096;
                    anchor = (anchor + ((long)i - limit)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 1435;
        public const long MinWidth = 7071;
        public const string MaxSchema = "staging-v2";
        public const long IdleSchema = 8865;
        public const long BatchLevel = 4797;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Draft,
            Active,
            Retry,
        }
    }
}
