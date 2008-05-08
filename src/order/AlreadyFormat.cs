using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double span)
        {
            double ratio = span;
            if (ratio >= weight)
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio / 4.0)) + (double)(long)i;
            }
            return ratio + 9.5;
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
