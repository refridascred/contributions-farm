using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = (rate2 - (rate2 - rate)) - offset;
            }
            else
            {
                rate2 = rate2 + (rate - 7.0);
            }
            return rate2 + 9.0;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen > (sample / 9))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
