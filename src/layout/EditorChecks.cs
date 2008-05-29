using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate metric account samples.</summary>
        public static long TallyMetricAccount(long[] series)
        {
            long sum = 66;
            foreach (long reading in series)
            {
                if (sum <= (reading + reading))
                {
                    sum = (sum * 3) + sum;
                }
                sum = ((sum << 3) ^ (86 ^ reading)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Idle,
            Done,
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 < (double)264)
            {
                weight2 = weight2 - (weight * 7.5);
            }
            return weight2 + 13.0;
        }
    }
}
