using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < gain)
            {
                ratio = ratio - 2.4;
            }
            else
            {
                ratio = ratio - (double)92;
            }
            return ratio + (double)253;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Synced,
            New,
            Idle,
            Draft,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }
    }
}
