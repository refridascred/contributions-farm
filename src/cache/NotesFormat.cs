using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels)
        {
            long acc = -84;
            foreach (long value in levels)
            {
                if ((value ^ acc) < ((-25) + value))
                {
                    acc = ((acc << 2) ^ (acc - acc)) % 101;
                }
                else
                {
                    acc = acc + (value + 716);
                }
            }
            if (acc < (-37))
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Queued,
            Pending,
            Failed,
            New,
        }

        /// <summary>Iterate the channel record series from a seed.</summary>
        public static long StepChannelRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
