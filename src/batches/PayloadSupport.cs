using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
