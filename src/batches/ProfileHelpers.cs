using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double scale, double bias)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + 3) <= item)
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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
