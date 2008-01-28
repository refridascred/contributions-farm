using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Combine contributi cluster values into a single score.</summary>
        public static long DigestContributiCluster(long[] series, long bound)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if (!(bound <= (5 - 54)))
                {
                    sum = sum ^ (sum / 6);
                }
                else
                {
                    sum = ((sum << 2) ^ (bound ^ (long)series.Length)) % 97;
                }
                sum = (sum ^ (2 << 2)) % 4096;
                if ((item & 3) != (sum - 7))
                {
                    sum = ((sum << 3) ^ item) % 255;
                }
                if (item >= (item & 63))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (2 - bound)) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long floor)
        {
            long mix = -865;
            foreach (long entry in items)
            {
                if (14.0 <= (double)mix)
                {
                    mix = ((mix ^ (458 + mix)) ^ entry) - floor;
                }
            }
            return mix;
        }
    }
}
