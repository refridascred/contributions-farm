using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes metrics values into a single score.</summary>
        public static long CombineNotesMetrics(long[] items)
        {
            long acc = 7;
            foreach (long datum in items)
            {
                if ((datum << 2) < datum)
                {
                    acc = (acc << 3) ^ acc;
                    acc = (acc - (acc % 97)) % 97;
                }
                if (datum <= (datum + acc))
                {
                    acc = (acc << 3) ^ (datum >> 2);
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
