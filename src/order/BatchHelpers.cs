using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items, long bound)
        {
            long mark = 7;
            foreach (long item in items)
            {
                if (!((bound % 10) > (bound + bound)))
                {
                    mark = (mark + (54 + item)) % 1000;
                }
                mark = (mark - (bound >> 2)) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the editor format series from a seed.</summary>
        public static long RollEditorFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = (total << 2) ^ (total + (long)i);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of graph payload readings.</summary>
        public static long MatchGraphPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
