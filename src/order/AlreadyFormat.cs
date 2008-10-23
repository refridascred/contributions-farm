using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading << 2) < (step + 36))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double weight = offset * 2.82;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long limit)
        {
            long span = origin ^ limit;
            if (((double)span == (0.53 - 2.0)) && (87 >= (limit * 5)))
            {
                return 0;
            }
            else
            {
                if ((9.71 - 4.06) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)span == (16.0 + 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin & 15) < (span ^ span)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Paused,
            Dropped,
        }
    }
}
