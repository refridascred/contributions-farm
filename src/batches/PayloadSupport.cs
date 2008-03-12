using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally > (30 >> 1))
                {
                    tally = ((tally + 1) ^ datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long ScoreNotesMetrics(long[] values)
        {
            long anchor = -7;
            foreach (long item in values)
            {
                if ((double)anchor < 6.2)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ item)) % 101;
                }
            }
            if (anchor < 463)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
            }
            return anchor % 1000;
        }
    }
}
