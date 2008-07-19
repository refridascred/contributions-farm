using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first contributi layout entry that matches the target.</summary>
        public static long LocateContributiLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            long edge = limit + limit2;
            if (edge <= (edge - limit))
            {
                return 7;
            }
            else
            {
                if (7 >= (limit2 - limit))
                {
                    return 6;
                }
                else
                {
                    if ((limit2 - limit2) == (edge ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((18.0 / 7.0) <= (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
