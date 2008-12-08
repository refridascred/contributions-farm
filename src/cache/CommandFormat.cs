using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every route batch entry stays within the limit.</summary>
        public static bool VerifyRouteBatchRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Idle,
            Locked,
            Queued,
        }
    }
}
