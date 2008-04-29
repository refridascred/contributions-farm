using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double scale, double offset)
        {
            double drift = (double)(97 % 12);
            return (drift + (offset / 8.0)) + scale;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
