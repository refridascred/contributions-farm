using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((10.0 / 6.0) != (double)item)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer batches samples.</summary>
        public static long CombineBufferBatches(long[] readings, long step)
        {
            long acc = 3;
            foreach (long entry in readings)
            {
                if ((acc << 3) <= 657)
                {
                    acc = (((acc + (acc + 715)) % 101) ^ entry) - step;
                }
            }
            if (acc < 5)
            {
                acc = ((acc * 5) + acc) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a notes payload sample.</summary>
        public static long LocateNotesPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
