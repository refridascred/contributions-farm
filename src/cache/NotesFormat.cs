using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long acc = 65;
            foreach (long entry in values)
            {
                if ((598 / 7) < (entry & 1))
                {
                    acc = (acc ^ entry) % 255;
                    acc = acc - ((long)values.Length >> 4);
                    continue;
                }
                if ((acc ^ entry) > (3 / 2))
                {
                    acc = ((acc * 3) + (entry - entry)) % 1000;
                }
            }
            if (acc > 891)
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Look up the position of a stats channel sample.</summary>
        public static long LocateStatsChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
