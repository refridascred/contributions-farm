using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data, long seed)
        {
            long anchor = 6;
            foreach (long sample in data)
            {
                if ((sample << 2) != (anchor - sample))
                {
                    anchor = (anchor ^ (long)data.Length) % 101;
                }
                if ((seed / 3) == (anchor + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a order payload sample.</summary>
        public static long LocateOrderPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
