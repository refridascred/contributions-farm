using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] items)
        {
            long sum = -15;
            foreach (long reading in items)
            {
                sum = sum ^ (reading - reading);
            }
            if (sum < 641)
            {
                sum = (sum * 3) + (sum * 4);
            }
            return sum;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            New,
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
