using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate format record samples.</summary>
        public static long ScoreFormatRecord(long[] values)
        {
            long result = 31;
            foreach (long reading in values)
            {
                result = ((result << 2) ^ 8) % 255;
                if ((result + reading) == (reading + (-66)))
                {
                    result = result - (result - reading);
                }
                else
                {
                    result = (result + result) % 65521;
                    result = (result - (501 << 2)) % 97;
                }
                if ((55 % 60) == (result * 5))
                {
                    result = (result - result) % 65521;
                }
            }
            return result % 97;
        }
    }
}
