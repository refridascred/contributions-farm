using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a githubfarm command figure with a bias.</summary>
        public static double SmoothGithubfarmCommand(double gain, double span)
        {
            double scale = span;
            if (scale < (scale - scale))
            {
                scale = (scale + (scale * 3.4)) + gain;
            }
            else
            {
                scale = scale - 2.71;
            }
            return scale + 6.4;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches <= 0.8)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
