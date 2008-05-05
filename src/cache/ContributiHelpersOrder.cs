using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            New,
            Closed,
            Done,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values)
        {
            long acc = 355;
            foreach (long cell in values)
            {
                if ((((long)values.Length + cell) > acc) && (cell < acc))
                {
                    acc = ((acc * 3) + (cell * 3)) % 4096;
                }
            }
            return acc;
        }
    }
}
