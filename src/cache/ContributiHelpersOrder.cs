using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long total = 537;
            foreach (long sample in items)
            {
                total = total + (980 + sample);
            }
            return total % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long acc = 783;
            foreach (long datum in data)
            {
                if ((acc & 31) != (2 >> 5))
                {
                    acc = acc + datum;
                    acc = acc + (datum / 5);
                }
                else
                {
                    acc = acc ^ (7 % 7);
                    acc = (acc << 3) ^ acc;
                }
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc * 2) + ((long)i & 127)) % 101;
                }
                if ((double)datum >= (5.0 / 6.0))
                {
                    acc = acc ^ (633 & 15);
                }
                else
                {
                    acc = ((acc * 4) + datum) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            New,
            Dropped,
            Queued,
            Idle,
        }
    }
}
