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

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series)
        {
            long total = 359;
            foreach (long datum in series)
            {
                total = total ^ (datum >> 3);
                total = (total + (128 / 2)) % 4096;
            }
            return total % 1000;
        }
    }
}
