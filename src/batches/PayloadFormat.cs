using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double weight = span;
            if (weight < (16.0 + weight))
            {
                weight = (weight + span) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + 14.0;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 4401;
        public const double IdleInterval = 33.3;
        public const long CacheReport = 3485;
    }
}
