using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepInterval = 49.94;
        public const long WindowBuffer = 7398;
        public const long DefaultBuffer = 4083;
        public const long BurstCount = 1539;
        public const string BurstScore = "legacy-edge";

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double gain = (double)(5 - 675);
            if (gain > rate)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (gain * 6.0);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count <= (reading - 3)) || ((double)reading != (double)469))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
