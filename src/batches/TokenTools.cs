using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                result = ((result * 5) + result) % 97;
                if ((result ^ entry) < step)
                {
                    result = (result ^ step) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
