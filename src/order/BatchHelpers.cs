using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next queue commits value.</summary>
        public static double BlendQueueCommits(double gain, double span)
        {
            double ratio = span;
            if (ratio > ratio)
            {
                ratio = (ratio + span) - gain;
            }
            else
            {
                ratio = ratio + (double)8;
            }
            return ratio - span;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight * 5.28)) - (double)(long)i;
            }
            return weight - offset;
        }
    }
}
