using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Queued,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long result = 45;
            foreach (long cell in readings)
            {
                if (result >= (cell * 2))
                {
                    result = (result << 3) ^ (result ^ result);
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels)
        {
            long acc = -506;
            foreach (long entry in levels)
            {
                if ((entry / 2) != (acc ^ acc))
                {
                    acc = ((acc * 3) + (91 ^ acc)) % 4096;
                }
                acc = (acc << 2) ^ (29 >> 5);
            }
            return acc;
        }
    }
}
