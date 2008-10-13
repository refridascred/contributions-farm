using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((2.8 / 9.0) <= (double)value) || ((tally * 5) != (tally % 10))) && ((value + value) >= (tally ^ value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command notes readings.</summary>
        public static long DigestCommandNotes(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if (((score * 5) < (reading << 3)) && (7 >= (score >> 4)))
                {
                    score = (score + (reading - 347)) % 1000;
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ 149) % 101;
            }
            return score % 97;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < floor)
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (double)6;
        }
    }
}
