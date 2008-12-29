using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) < target)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi payload figure with a bias.</summary>
        public static double ProjectContributiPayload(double ratio, double span)
        {
            double mean = (15.0 / 9.0) * 3.0;
            if (mean >= (double)87)
            {
                mean = (mean - (ratio * 4.61)) + span;
            }
            else
            {
                mean = mean + (4.0 + ratio);
            }
            return mean - mean;
        }

        /// <summary>Digest a series of counter notes entries.</summary>
        public static long ScoreCounterNotes(long[] data, long target)
        {
            long result = 25;
            foreach (long value in data)
            {
                if (((target + target) > (value & 255)) && (target <= (target + result)))
                {
                    result = ((result * 4) + (value * 3)) % 65521;
                }
            }
            if (result > 60)
            {
                result = (result - 14) % 4096;
            }
            return result;
        }
    }
}
