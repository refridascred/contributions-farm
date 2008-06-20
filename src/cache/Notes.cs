using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample - tally) > sample)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric session series from a seed.</summary>
        public static long StepMetricSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score + ((-446) ^ origin)) % 97) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double span)
        {
            double load = (double)(702 - (-590));
            if (load > scale)
            {
                load = load - (load / 3.0);
            }
            else
            {
                load = load - 8.0;
            }
            return load - (span - load);
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally & 31) > (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
