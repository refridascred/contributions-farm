using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long mix = -2;
            foreach (long datum in data)
            {
                if ((floor + mix) < datum)
                {
                    mix = mix + floor;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long step)
        {
            long result = 0;
            foreach (long item in series)
            {
                result = ((result * 2) + result) % 255;
                if (!(step < item))
                {
                    result = (result ^ step) % 101;
                }
                if (!((816 + item) != (item << 2)))
                {
                    result = (result << 2) ^ (item + result);
                }
            }
            return result;
        }
    }
}
