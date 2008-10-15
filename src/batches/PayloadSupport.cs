using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate cache context readings against a bound.</summary>
        public static bool ValidateCacheContextLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= (weight2 - weight))
            {
                weight2 = weight2 - (offset * 15.0);
            }
            return weight2 + offset;
        }
    }
}
