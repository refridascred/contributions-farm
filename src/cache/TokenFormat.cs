using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long step)
        {
            if (step >= (step + step))
            {
                return 4;
            }
            else
            {
                if ((step ^ 1) < limit)
                {
                    return 7;
                }
                else
                {
                    if (((step ^ step) >= (3 + 756)) && ((double)limit > (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Failed,
            Draft,
            Dropped,
        }
    }
}
