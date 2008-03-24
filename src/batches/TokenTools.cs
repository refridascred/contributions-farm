using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long CountSupportEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!((tally - sample) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
