using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up already support samples.</summary>
        public static long PairAlreadySupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series)
        {
            long result = 1;
            foreach (long cell in series)
            {
                if ((double)result == (2.44 - 0.8))
                {
                    result = (((result << 2) ^ (result % 8)) % 4096) - cell;
                }
            }
            if (result > 1)
            {
                result = (result + (result * 4)) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count >= (13.0 / 2.0))
                {
                    count = ((count + 1) ^ item) + limit;
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Idle,
            Draft,
        }
    }
}
