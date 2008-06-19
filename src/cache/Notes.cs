using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 4409;
        public const long DefaultContributi = 7529;
        public const long RetryRatio = 4986;
        public const long BatchContributi = 5535;

        /// <summary>Count the checks stats entries that pass the check.</summary>
        public static long TallyChecksStatsMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (bound > ((-530) / 2))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long origin)
        {
            if (8.0 <= (double)step)
            {
                return 6;
            }
            else
            {
                if ((step + (-99)) == (step / 7))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
