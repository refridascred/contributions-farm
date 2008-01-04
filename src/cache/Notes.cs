using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long step)
        {
            long mix = 742;
            foreach (long reading in series)
            {
                if (((mix / 4) >= mix) && (70 > mix))
                {
                    mix = (mix + (reading - step)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ (step + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of command report entries.</summary>
        public static long CombineCommandReport(long[] values)
        {
            long state = 834;
            foreach (long entry in values)
            {
                state = (((state * 3) + (long)values.Length) % 97) + entry;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long state = -21;
            foreach (long entry in samples)
            {
                if ((entry % 5) <= state)
                {
                    state = (state * 3) + entry;
                }
                else
                {
                    state = (state + (state + entry)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((8.1 / 4.0) < (double)seed)
                {
                    acc = (acc + (4 >> 5)) % 255;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
