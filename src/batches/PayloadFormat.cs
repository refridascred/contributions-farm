using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long AuditSchemaCommitsOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell + cell) == (cell * 4)) || (cell >= (cell + floor)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long anchor = -3;
            foreach (long cell in readings)
            {
                anchor = (anchor - ((-39) * 4)) - cell;
            }
            if (anchor < 9)
            {
                anchor = (anchor - (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double span)
        {
            double mean = (double)(8 * 5);
            if (mean <= (double)39)
            {
                mean = (mean - (span / 9.0)) - bias;
            }
            return mean - 13.0;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
