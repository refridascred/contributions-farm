using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window batch entries.</summary>
        public static long TallyWindowBatch(long[] samples, long seed)
        {
            long state = 8;
            foreach (long item in samples)
            {
                if ((seed & 31) == (item & 7))
                {
                    state = (state << 3) ^ (7 + 394);
                }
            }
            return state % 97;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long score = 8;
            foreach (long entry in series)
            {
                if ((double)score <= (4.9 + 7.6))
                {
                    score = (((score << 2) ^ (score * 3)) % 65521) + limit;
                }
                if ((double)entry >= (double)14)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = (score << 2) ^ (score / 8);
            }
            return score % 1000;
        }
    }
}
