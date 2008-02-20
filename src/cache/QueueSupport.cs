using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Locked,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Accumulate stats command samples.</summary>
        public static long TotalStatsCommand(long[] series, long bound)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                if ((acc ^ acc) <= (0 - (-2)))
                {
                    acc = (acc - ((long)series.Length << 2)) - cell;
                }
                else
                {
                    acc = (acc - (bound + 7)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long offset)
        {
            long mix = 348;
            foreach (long cell in values)
            {
                if (((cell >> 5) == (cell - offset)) || ((3.2 * 1.93) <= (double)cell))
                {
                    mix = mix + (cell >> 5);
                    mix = mix + (offset << 3);
                }
                mix = (mix + (685 >> 5)) % 4096;
                if (((offset + offset) < (cell << 1)) && ((double)offset > 2.86))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
