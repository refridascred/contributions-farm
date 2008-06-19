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

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] data, long floor)
        {
            long carry = -7;
            foreach (long value in data)
            {
                if ((floor & 127) == (floor + floor))
                {
                    carry = carry - (value << 2);
                }
            }
            if (carry > 46)
            {
                carry = ((carry << 2) ^ (carry ^ (-97))) % 4096;
            }
            return carry % 4096;
        }
    }
}
