using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double scale = gain - gain;
            if (scale > (scale + gain))
            {
                scale = scale + gain;
            }
            return scale + (8.0 - span);
        }
    }
}
