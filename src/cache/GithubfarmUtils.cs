using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values)
        {
            long carry = 257;
            foreach (long reading in values)
            {
                carry = (carry - (reading >> 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }
    }
}
