using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batches commits measurements.</summary>
        public static double SmoothBatchesCommits(double rate, double floor)
        {
            double gain = rate;
            if (gain <= (double)788)
            {
                gain = gain + (gain * 4.55);
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (floor - floor);
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long target)
        {
            if (target >= (588 + limit))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) == (limit - 9))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Token { get; set; }
            public double Count { get; set; }
        }
    }
}
