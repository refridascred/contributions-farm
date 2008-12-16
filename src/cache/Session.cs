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

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "alpha-1";
        public const double WindowScore = 21.84;
        public const double SoftLevel = 59.01;
        public const double WindowFilter = 52.15;
        public const double LimitRatio = 89.55;

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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
