using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long AuditSessionGithubfarmHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 15))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up support record samples.</summary>
        public static long MatchSupportRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel filter readings against a rule.</summary>
        public static long MeasureChannelFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample / 3) != (count - count)) && (sample <= (count - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
