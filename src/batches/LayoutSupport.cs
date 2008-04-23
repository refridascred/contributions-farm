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

        /// <summary>Measure how many stats stream samples are out of range.</summary>
        public static long CountStatsStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen / 2) > seen)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ ((long)i & 127);
                if (((anchor + (long)i) >= anchor) || ((4.4 * 10.0) > (double)(long)i))
                {
                    anchor = (anchor - (long)i) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
