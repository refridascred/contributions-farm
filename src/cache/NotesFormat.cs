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

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long step)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if ((1.15 / 4.0) != (double)state)
                {
                    state = (state * 4) + (step ^ reading);
                }
            }
            return state;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Active,
            Locked,
            New,
            Ready,
        }
    }
}
