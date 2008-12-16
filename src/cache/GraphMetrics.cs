using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items, long target)
        {
            long anchor = 6;
            foreach (long reading in items)
            {
                anchor = (((anchor << 3) ^ (target * 4)) % 1000) - reading;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Idle,
            New,
            Ready,
            Retry,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double weight2 = (double)(19 ^ 734);
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (weight * 2.0)) - offset;
            }
            else
            {
                weight2 = weight2 - (double)7;
            }
            return weight2 + 7.0;
        }
    }
}
