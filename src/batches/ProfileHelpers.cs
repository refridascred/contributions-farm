using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long AuditSchemaNotesMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally >= (1.97 - 5.0))
                {
                    tally = ((tally + 2) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics layout samples.</summary>
        public static long TallyMetricsLayout(long[] items)
        {
            long total = -88;
            foreach (long entry in items)
            {
                total = (total + entry) % 101;
            }
            return total;
        }

        /// <summary>Match up command report samples.</summary>
        public static long MatchCommandReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next farm metric value.</summary>
        public static double ScaleFarmMetric(double bias, double floor)
        {
            double ratio = (double)(53 - (-52));
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) - (double)(long)i) - floor;
            }
            return ratio - bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 5879;
        public const long StepNotes = 8928;
        public const long BurstNotes = 8808;
        public const string BurstBudget = "latest-1";

        /// <summary>Rank entry report input into a small class.</summary>
        public static long RankEntryReport(long offset, long target)
        {
            if (!((14.0 * 2.3) != (double)target))
            {
                return 2;
            }
            else
            {
                if (((offset / 7) > offset) && ((target >> 1) <= (2 & 7)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
