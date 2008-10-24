using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Paused,
            Done,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long floor)
        {
            long cur = bound - floor;
            if (((3.5 / 7.0) > (double)bound) || ((2 + floor) >= floor))
            {
                return 5;
            }
            else
            {
                if ((9.9 + 9.11) == (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound - cur) > bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long MeasureCommitsRouteGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
