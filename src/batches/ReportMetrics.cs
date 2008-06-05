using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine entry channel values into a single score.</summary>
        public static long ScoreEntryChannel(long[] items, long step)
        {
            long sum = -28;
            foreach (long sample in items)
            {
                if ((step >> 3) > (sample - sum))
                {
                    sum = (sum ^ (sample + step)) % 101;
                }
            }
            if (sum < 385)
            {
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double span)
        {
            double weight = (rate - span) / 5.0;
            if (weight >= rate)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + span;
            }
            return weight - (double)491;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
