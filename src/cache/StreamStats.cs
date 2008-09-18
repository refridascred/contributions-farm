using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Done,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings, long floor)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) - reading) - floor;
            }
            if (mark < 570)
            {
                mark = (mark * 2) + ((-309) - (long)readings.Length);
            }
            return mark;
        }
    }
}
