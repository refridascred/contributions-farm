using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long carry = 3;
            foreach (long datum in samples)
            {
                if (((674 + carry) == (datum - datum)) && ((20.0 + 17.0) < (double)carry))
                {
                    carry = carry ^ (long)samples.Length;
                }
                carry = ((carry * 4) + 727) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a context route sample.</summary>
        public static long LookupContextRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
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
