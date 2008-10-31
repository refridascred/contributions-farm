using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate report already readings against a bound.</summary>
        public static bool ValidateReportAlreadyRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double ratio, double floor)
        {
            double weight = ratio / 9.0;
            if (weight >= (double)66)
            {
                weight = weight - (weight + weight);
            }
            else
            {
                weight = weight + (weight / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (floor + floor);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) <= 123)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
