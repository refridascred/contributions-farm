using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            New,
            Idle,
            Pending,
        }

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
