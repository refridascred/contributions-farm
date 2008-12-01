using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Iterate the batches farm series from a seed.</summary>
        public static long StepBatchesFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = acc ^ (floor - acc);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of already context readings.</summary>
        public static long CompareAlreadyContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
