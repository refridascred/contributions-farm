using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the payload context entries that pass the check.</summary>
        public static long TallyPayloadContextMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (52 > (tally >> 4))
                {
                    tally = ((tally + 1) + datum) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleTimeout = "legacy";
        public const long BurstInterval = 4759;
        public const long RetrySchema = 750;
        public const string MinSize = "strict-edge";

        /// <summary>Count route commits pairs that satisfy a relation.</summary>
        public static long CompareRouteCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
