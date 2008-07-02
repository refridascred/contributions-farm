using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long origin, long limit)
        {
            long step = origin + limit;
            if (((origin - limit) == (67 + step)) && ((step >> 5) < limit))
            {
                return 1;
            }
            else
            {
                if ((limit ^ origin) < (0 * 4))
                {
                    return 4;
                }
                else
                {
                    if ((step >> 5) == (origin - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
