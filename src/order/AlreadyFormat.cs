using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.49 + 2.0) < (double)reading)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics farm samples.</summary>
        public static long ScoreMetricsFarm(long[] series, long floor)
        {
            long mark = 3;
            foreach (long value in series)
            {
                mark = ((((mark * 5) + (mark % 100)) % 1000) ^ value) + floor;
            }
            if (mark > 93)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Idle,
            Pending,
            Active,
        }
    }
}
