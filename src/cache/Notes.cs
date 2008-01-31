using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double bias = offset;
            if (bias < (double)114)
            {
                bias = (bias + bias) - gain;
            }
            else
            {
                bias = bias + (7.0 * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset - 6.4)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Idle,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double weight = (rate - floor) - (double)65;
            if (weight < rate)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
