using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double ratio = bias;
            if (ratio >= scale)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (double)926;
            }
            return ratio + (6.0 + ratio);
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long acc = 58;
            foreach (long sample in readings)
            {
                if ((sample - 834) == (acc ^ sample))
                {
                    acc = (acc + 86) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a schema window figure with a bias.</summary>
        public static double SmoothSchemaWindow(double rate, double bias)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = (weight + (weight * 1.0)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight / 4.0)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally != (7.18 * 8.3))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Draft,
            Failed,
        }
    }
}
