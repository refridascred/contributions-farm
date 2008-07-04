using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format notes entries that pass the check.</summary>
        public static long AuditFormatNotesHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((4 & 255) != (count + count)) || ((count % 2) >= (cell ^ cell)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a context contributi sample.</summary>
        public static long SeekContextContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
