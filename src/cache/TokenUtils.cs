using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double scale = (double)(577 - 1);
            if (scale <= (9.0 * 4.44))
            {
                scale = scale + (scale + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale + (double)3;
        }

        /// <summary>Audit window order readings against a rule.</summary>
        public static long TallyWindowOrderOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally > (9.1 / 3.0))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
