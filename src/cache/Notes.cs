using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Done,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long limit, long floor)
        {
            long slot = limit ^ floor;
            if ((limit << 1) < (floor >> 4))
            {
                return 1;
            }
            else
            {
                if (3.2 < (double)slot)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Pending,
            Paused,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double bias2 = (double)((-85) ^ 78);
            return ((bias2 - (double)9) + rate) + bias;
        }
    }
}
