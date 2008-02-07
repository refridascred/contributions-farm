using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of cache farm readings.</summary>
        public static long MatchCacheFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally << 2) >= (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values, long offset)
        {
            long result = 7;
            foreach (long entry in values)
            {
                result = (result + (result + entry)) % 65521;
                if (!((double)result == (double)offset))
                {
                    result = ((result << 3) ^ (result + 1)) % 4096;
                }
                if ((result >> 1) >= result)
                {
                    break;
                }
            }
            if (result < (-4))
            {
                result = result ^ (offset % 100);
            }
            return result % 65521;
        }
    }
}
