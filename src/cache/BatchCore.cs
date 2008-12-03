using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((floor <= (tally % 60)) && ((floor > tally) && (5.94 > (double)tally)))
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema record readings.</summary>
        public static long FoldSchemaRecord(long[] series, long seed)
        {
            long mark = -42;
            foreach (long sample in series)
            {
                mark = ((mark * 4) + seed) + sample;
                if ((seed & 1) <= (mark >> 5))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (seed / 7)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Count account window pairs that satisfy a relation.</summary>
        public static long MatchAccountWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
