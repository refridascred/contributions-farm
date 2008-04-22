using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next buffer batch value from a seed.</summary>
        public static long SeriesBufferBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if (offset > (total + 4))
                {
                    break;
                }
                else
                {
                    total = (total + (49 % 97)) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double floor)
        {
            double drift = floor;
            if (drift > (1.04 / 4.0))
            {
                drift = drift - (floor * 7.0);
            }
            else
            {
                drift = drift + (gain + gain);
            }
            return drift - drift;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }
    }
}
