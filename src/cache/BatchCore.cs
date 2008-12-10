using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                score = score + (-879);
                if ((2.41 - 9.0) == (double)value)
                {
                    score = ((score * 5) + (score - value)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long target)
        {
            long slot = origin ^ target;
            if ((9.87 / 9.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if (2.9 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((slot + 9) < (slot + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
