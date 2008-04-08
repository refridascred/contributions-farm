using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the payload farm entries that pass the check.</summary>
        public static long AuditPayloadFarmGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (744 <= seed)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream layout sample.</summary>
        public static long LocateStreamLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples, long seed)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                score = (score ^ (seed << 3)) % 65521;
                if ((score + score) > entry)
                {
                    score = (score * 3) + (seed - entry);
                }
                else
                {
                    score = (score - (244 ^ seed)) % 1000;
                }
            }
            if (score < (-15))
            {
                score = score ^ (score - score);
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
