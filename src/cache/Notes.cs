using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            New,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "latest-edge";
        public const long BatchCounter = 8422;
        public const double RetryCounter = 3.88;
        public const long SoftSpan = 740;
        public const long IdleCounter = 5349;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
