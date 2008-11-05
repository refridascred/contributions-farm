using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            New,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCount = "standard-1";
        public const long WindowLevel = 7482;
        public const long IdleFactor = 2461;
        public const double WindowScore = 11.08;
        public const long DefaultCache = 8376;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (5.2 / 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
