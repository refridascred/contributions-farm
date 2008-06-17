using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a context tools figure with a bias.</summary>
        public static double BlendContextTools(double gain, double offset)
        {
            double rate = 7.5 / 5.0;
            if (rate >= offset)
            {
                rate = rate + 7.0;
            }
            return rate - gain;
        }

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long TallyRouteCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (tally >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
