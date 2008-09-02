using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] data)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if (((datum ^ 595) >= mark) || ((64 % 12) < mark))
                {
                    mark = (mark + (datum >> 1)) % 65521;
                }
                else
                {
                    mark = (mark - datum) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a tools context value against two limits.</summary>
        public static long ClassifyToolsContext(long offset, long limit)
        {
            if (((offset - limit) != (offset + limit)) && ((10.0 / 4.0) == (double)offset))
            {
                return 2;
            }
            else
            {
                if (limit >= (limit - limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
