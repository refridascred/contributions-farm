using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
