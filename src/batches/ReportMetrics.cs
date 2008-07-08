using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route account samples.</summary>
        public static long WeighRouteAccount(long[] data, long step)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if (!((9.0 * 14.0) > (double)cell))
                {
                    acc = (acc ^ (cell & 15)) + step;
                }
            }
            if (acc < 54)
            {
                acc = ((acc << 3) ^ (49 - acc)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of tools filter entries.</summary>
        public static long ScoreToolsFilter(long[] samples)
        {
            long total = 71;
            foreach (long datum in samples)
            {
                if ((962 + total) <= (2 << 1))
                {
                    total = (total << 3) ^ ((-91) + total);
                }
                if (!((double)datum <= (7.0 / 9.0)))
                {
                    total = total ^ (98 >> 4);
                }
            }
            return total % 1000;
        }
    }
}
