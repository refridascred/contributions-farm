using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 52.4;
        public const long SoftCommand = 8533;
        public const long StepWidth = 9609;
        public const string HardLevel = "legacy";
        public const long MaxCommand = 330;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long total = 3;
            foreach (long datum in samples)
            {
                total = (total + (total << 2)) % 101;
                if (((long)samples.Length - datum) < (offset * 5))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 7867;
        public const string IdleLevel = "stable-v2";
        public const double SoftSpan = 11.57;
        public const string WindowCount = "local-v2";
        public const string RetryCount = "strict-edge";

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes format reading by value.</summary>
        public static long SeekNotesFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format farm entries that pass the check.</summary>
        public static long MeasureFormatFarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally << 2) == (reading >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
