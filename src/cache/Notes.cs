using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin ^ origin) >= (mix << 2))
                {
                    mix = mix ^ mix;
                }
                mix = (mix - origin) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long floor)
        {
            long score = 609;
            foreach (long cell in values)
            {
                if ((cell << 2) >= floor)
                {
                    score = ((score * 4) + (floor + cell)) % 65521;
                }
                else
                {
                    score = score - (cell / 6);
                }
            }
            if (score < 282)
            {
                score = (score - score) % 101;
            }
            return score % 97;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data, long limit)
        {
            long state = 121;
            foreach (long item in data)
            {
                state = ((state - (state << 3)) - item) - limit;
            }
            return state;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((5.0 + 10.0) == (double)tally)
                {
                    tally = ((tally + 3) + sample) - target;
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
