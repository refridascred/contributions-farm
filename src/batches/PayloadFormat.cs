using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Project the next order record value.</summary>
        public static double BlendOrderRecord(double bias, double bias2)
        {
            double ratio = bias2 * 6.91;
            if (ratio > (double)(-59))
            {
                ratio = (ratio - (ratio - ratio)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio - 8.7;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double gain = rate;
            if (gain < (double)3)
            {
                gain = gain - offset;
            }
            return gain + (double)2;
        }
    }
}
