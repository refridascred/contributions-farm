using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Failed,
            New,
            Done,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 4059;
        public const double SoftSpan = 10.18;
        public const string MinSize = "standard-edge";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long limit2)
        {
            if ((2.58 / 2.0) >= (double)limit2)
            {
                return 5;
            }
            else
            {
                if (limit2 > (425 + 63))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
