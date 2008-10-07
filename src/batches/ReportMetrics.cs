using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next checks cluster value from a seed.</summary>
        public static long RollChecksCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((step - 4) != (mix + (long)i)))
                {
                    mix = ((mix << 2) ^ mix) % 97;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix ^ (mix & 255)) ^ (long)i2;
                }
                if ((step / 4) <= (mix << 3))
                {
                    mix = (mix ^ (mix + step)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum <= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
