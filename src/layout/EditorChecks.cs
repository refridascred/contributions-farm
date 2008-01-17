using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score ^ (score / 6)) % 97) - entry;
            }
            if (score < (-60))
            {
                score = (score ^ (bound % 12)) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of booking readings.</summary>
        public static long PairBookingCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
