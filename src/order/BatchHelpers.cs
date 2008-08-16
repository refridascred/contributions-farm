using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double offset)
        {
            double bias = offset + 1.44;
            if (bias > (gain - bias))
            {
                bias = bias + 3.2;
            }
            return bias + 1.4;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long reading in readings)
            {
                if ((carry + carry) >= carry)
                {
                    carry = ((carry ^ reading) % 65521) + offset;
                }
            }
            return carry;
        }
    }
}
