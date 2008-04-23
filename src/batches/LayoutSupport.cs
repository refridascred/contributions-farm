using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (scale / 9.0))
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - bias;
        }

        /// <summary>Combine githubfarm window values into a single score.</summary>
        public static long DigestGithubfarmWindow(long[] samples)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = (state ^ entry) % 255;
            }
            if (state > 6)
            {
                state = ((state * 5) + (state ^ state)) % 65521;
            }
            return state;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double floor)
        {
            double rate = (weight * 3.0) / 4.0;
            if (rate <= 1.55)
            {
                rate = (rate + (double)272) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (6.3 + weight)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] samples, long target)
        {
            long anchor = 823;
            foreach (long entry in samples)
            {
                if ((9.0 - 3.4) > (double)anchor)
                {
                    anchor = ((anchor * 2) + (target / 9)) - entry;
                }
            }
            if (anchor > 56)
            {
                anchor = anchor ^ target;
            }
            return anchor;
        }
    }
}
