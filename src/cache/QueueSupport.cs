using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a batch editor reading.</summary>
        public static double BlendBatchEditor(double gain, double floor)
        {
            double scale = (gain + gain) - (gain - floor);
            if (scale > (scale + gain))
            {
                scale = scale + (gain * 13.0);
            }
            else
            {
                scale = scale - 9.53;
            }
            return scale + (double)(-232);
        }
    }
}
