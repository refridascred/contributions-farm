using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count metric contributi pairs that satisfy a relation.</summary>
        public static long OverlapMetricContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((-94) > (tally % 5))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples)
        {
            long result = 38;
            foreach (long datum in samples)
            {
                if (((result - 6) >= (datum << 3)) || (17 > (result + 368)))
                {
                    result = (result + (datum % 12)) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (result & 63)) % 4096;
                }
            }
            return result;
        }
    }
}
