using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((716 < (offset + tally)) || (sample < (tally / 8))) && ((tally * 3) >= sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi account readings against a rule.</summary>
        public static long AuditContributiAccountOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= ((long)series.Length * 2))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
