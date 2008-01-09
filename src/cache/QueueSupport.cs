using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long acc = 52;
            foreach (long sample in series)
            {
                if ((sample & 31) == (sample / 5))
                {
                    acc = (acc + (sample ^ acc)) % 65521;
                }
                else
                {
                    acc = ((acc << 2) ^ (1 - acc)) % 1000;
                }
            }
            if (acc < 6)
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Paused,
        }
    }
}
