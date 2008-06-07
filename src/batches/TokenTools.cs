using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((datum ^ tally) > (tally % 97)) && ((75 << 1) < (tally - tally))) || (tally <= (tally - datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((797 * 5) < (31 + origin))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
