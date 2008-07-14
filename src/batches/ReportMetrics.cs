using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cluster support readings against a rule.</summary>
        public static long TallyClusterSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ value) <= (matches & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a editor entry value against two limits.</summary>
        public static long RankEditorEntry(long limit, long origin)
        {
            long cur = limit - origin;
            if ((double)cur > (8.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((limit <= (cur + cur)) || (cur >= (cur - cur)))
                {
                    return 6;
                }
                else
                {
                    if ((cur << 3) != (origin ^ cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
