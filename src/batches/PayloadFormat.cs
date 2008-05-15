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

        /// <summary>Fold a list of route buffer readings.</summary>
        public static long FoldRouteBuffer(long[] items)
        {
            long total = 3;
            foreach (long value in items)
            {
                if (total <= (72 ^ value))
                {
                    total = (total << 2) ^ (value % 97);
                }
            }
            return total % 4096;
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
