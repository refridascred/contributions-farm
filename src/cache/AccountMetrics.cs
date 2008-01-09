using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first format stream entry that matches the target.</summary>
        public static long LocateFormatStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format tools readings against a rule.</summary>
        public static long AuditFormatToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (278 >= (tally / 3))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long CountCommitsFarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally - sample) < (5 - 684)) && ((9.5 / 8.0) < (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of farm notes readings.</summary>
        public static long PairFarmNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data)
        {
            long result = -1;
            foreach (long item in data)
            {
                if (((double)item < 5.7) && ((9.1 - 7.1) <= (double)item))
                {
                    result = (result * 2) + (item + result);
                }
            }
            return result;
        }
    }
}
