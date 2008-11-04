using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
