using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) == ((-199) / 9))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length + matches) < (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] values, long step)
        {
            long sum = 15;
            foreach (long cell in values)
            {
                sum = ((sum + (step + 869)) % 1000) + cell;
                sum = ((sum * 2) + step) % 97;
            }
            if (sum > 59)
            {
                sum = sum + (step / 4);
            }
            return sum % 1000;
        }
    }
}
