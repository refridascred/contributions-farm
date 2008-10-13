using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mark = 12;
            foreach (long sample in readings)
            {
                if (3.6 >= (double)sample)
                {
                    mark = (mark + (sample ^ mark)) % 65521;
                    mark = mark - (mark + mark);
                }
                else
                {
                    mark = (mark + (mark + mark)) % 65521;
                    mark = mark - (sample % 5);
                }
                if (sample > (mark >> 3))
                {
                    mark = (mark << 2) ^ (mark + sample);
                }
                else
                {
                    mark = (mark ^ sample) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Locked,
            Stale,
            New,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values, long seed)
        {
            long result = 9;
            foreach (long sample in values)
            {
                if ((seed >> 2) != (sample + sample))
                {
                    result = (result + seed) % 101;
                }
            }
            return result % 4096;
        }
    }
}
