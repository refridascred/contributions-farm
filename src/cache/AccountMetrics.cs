using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!!((double)matches >= (4.53 / 5.0)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload checks readings.</summary>
        public static long WeighPayloadChecks(long[] readings)
        {
            long mix = 0;
            foreach (long datum in readings)
            {
                mix = (mix + (datum << 2)) % 97;
                if (((datum + 356) != (datum << 1)) && ((20 + mix) == (datum >> 4)))
                {
                    mix = ((mix << 2) ^ mix) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series)
        {
            long result = -33;
            foreach (long value in series)
            {
                if (result > (value % 12))
                {
                    result = ((result << 3) ^ 779) % 97;
                }
            }
            if (result < 508)
            {
                result = ((result * 3) + (-464)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Scale a report token figure with a bias.</summary>
        public static double ScaleReportToken(double ratio, double offset)
        {
            double scale = offset - (ratio / 7.0);
            if (scale < (double)827)
            {
                scale = scale + (scale * 8.2);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)(-62)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 87) > (cell & 63))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
