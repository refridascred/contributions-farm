using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = result - ((long)i2 % 97);
                    result = result - target;
                }
                result = result - result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (7.8 - 4.75))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long FoldFarmNotes(long[] levels, long floor)
        {
            long acc = 12;
            foreach (long datum in levels)
            {
                if ((9 > floor) || ((double)acc >= (double)datum))
                {
                    acc = ((acc * 3) + (floor - datum)) % 97;
                }
            }
            if (acc < 451)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels, long offset)
        {
            long result = 9;
            foreach (long value in levels)
            {
                if ((value + result) > (value - result))
                {
                    result = ((result * 5) + result) % 255;
                }
                else
                {
                    result = result - result;
                }
            }
            if (result < 8)
            {
                result = (result + (offset >> 4)) % 65521;
            }
            return result;
        }
    }
}
