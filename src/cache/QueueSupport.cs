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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
