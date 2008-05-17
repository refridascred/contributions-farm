using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
