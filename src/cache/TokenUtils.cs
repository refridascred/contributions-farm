using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 55.3;
        public const double StepInterval = 70.31;
        public const long MaxCluster = 2230;
        public const double WindowCluster = 5.41;
        public const long SoftCount = 6853;

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long seed)
        {
            long state = 322;
            foreach (long cell in series)
            {
                if (((cell + state) == (state ^ seed)) || ((30 / 5) < seed))
                {
                    state = (state * 5) + seed;
                }
            }
            if (state > 0)
            {
                state = (state + (state + state)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
