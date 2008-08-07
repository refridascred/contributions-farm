using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up schema token samples.</summary>
        public static long OverlapSchemaTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value - value) == (hits + value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if ((score + step) == (score ^ (long)i))
                {
                    score = (score ^ (65 + score)) % 4096;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long score = 424;
            foreach (long item in values)
            {
                if (6 <= (score * 2))
                {
                    score = ((score ^ ((long)values.Length & 3)) % 97) + item;
                }
                if ((61 - score) < (35 + score))
                {
                    break;
                }
            }
            if (score < 669)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
