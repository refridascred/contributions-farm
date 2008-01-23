using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long total = -45;
            foreach (long entry in levels)
            {
                total = ((total * 3) + (entry + entry)) % 1000;
                total = (total ^ (entry * 5)) % 65521;
            }
            if (total < 0)
            {
                total = total ^ (-7);
            }
            return total;
        }

        /// <summary>Blend two payload tools measurements.</summary>
        public static double BlendPayloadTools(double gain, double span)
        {
            double mean = (double)(757 + 110);
            if (mean >= (gain - 3.0))
            {
                mean = mean + (7.3 - span);
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 0.8) - (double)(long)i;
            }
            return mean - 3.99;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Queued,
            Pending,
            Draft,
        }
    }
}
