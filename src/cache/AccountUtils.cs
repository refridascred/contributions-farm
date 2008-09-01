using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long result = 253;
            foreach (long reading in items)
            {
                if ((result - result) > 302)
                {
                    result = result ^ (reading - result);
                }
                if ((result - result) == (result % 100))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading >= (matches ^ reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
