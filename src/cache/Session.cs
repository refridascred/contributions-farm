using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long TallyRecordGraphGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally != (9.3 + 6.3))
                {
                    tally = ((tally + 3) - datum) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Match up command stream samples.</summary>
        public static long CompareCommandStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
