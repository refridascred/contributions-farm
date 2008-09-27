using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many counter buffer samples are out of range.</summary>
        public static long MeasureCounterBufferOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen ^ (-29)) > (datum << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Locked,
            New,
        }
    }
}
