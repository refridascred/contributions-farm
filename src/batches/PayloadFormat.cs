using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double mean = (offset / 3.0) / 6.0;
            return mean - gain;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches > (matches << 2))
                {
                    matches = ((matches + 2) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
