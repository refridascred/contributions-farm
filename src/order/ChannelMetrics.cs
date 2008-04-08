using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits already samples.</summary>
        public static long TallyCommitsAlready(long[] series)
        {
            long result = 0;
            foreach (long value in series)
            {
                if ((result + value) == (result - value))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = (result * 2) + (value / 2);
                }
            }
            return result;
        }

        /// <summary>Roll a contributi payload counter forward.</summary>
        public static long StepContributiPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 3) + (sum - 0);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine metrics graph values into a single score.</summary>
        public static long CombineMetricsGraph(long[] levels, long bound)
        {
            long mix = 670;
            foreach (long cell in levels)
            {
                if (bound < (mix << 2))
                {
                    mix = mix ^ (bound + cell);
                }
            }
            if (mix < 48)
            {
                mix = (mix - (bound << 3)) % 65521;
            }
            return mix;
        }
    }
}
