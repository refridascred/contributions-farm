using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of order record entries.</summary>
        public static long TotalOrderRecord(long[] series, long seed)
        {
            long mark = 94;
            foreach (long item in series)
            {
                if ((item - item) < 672)
                {
                    mark = mark + (-655);
                }
            }
            if (mark > 16)
            {
                mark = (mark - (seed >> 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up buffer stream samples.</summary>
        public static long OverlapBufferStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
