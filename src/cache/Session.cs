using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of format account readings.</summary>
        public static long OverlapFormatAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultBudget = 8392;
        public const double SoftSize = 11.55;
        public const double LimitScore = 22.26;
        public const long RetryProfile = 4111;

        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long SeriesFarmTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] series, long step)
        {
            long state = -2;
            foreach (long datum in series)
            {
                if (step < (step ^ step))
                {
                    state = (state * 5) + datum;
                }
                if (((step - datum) > (step + datum)) && ((double)state < (4.71 * 5.5)))
                {
                    state = ((state * 4) + (datum - 18)) % 1000;
                }
            }
            return state;
        }
    }
}
