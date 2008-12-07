using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double bias, double bias2)
        {
            double ratio = 3.2 - (double)71;
            return ((ratio + ratio) + bias) + bias2;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
