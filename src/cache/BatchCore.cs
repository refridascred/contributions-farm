using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            New,
            Paused,
            Ready,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long offset)
        {
            if (((offset / 9) < offset) && ((step ^ (-72)) > offset))
            {
                return 8;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (rate * 2.91);
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
