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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (step >= (count ^ step))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
