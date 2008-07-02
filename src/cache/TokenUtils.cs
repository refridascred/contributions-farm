using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor command values into a single score.</summary>
        public static long CombineEditorCommand(long[] data, long floor)
        {
            long mark = 4;
            foreach (long sample in data)
            {
                if (!!((6.6 * 5.7) >= (double)floor))
                {
                    mark = mark + (floor - sample);
                }
                if ((floor - sample) != (floor / 2))
                {
                    mark = (mark << 2) ^ sample;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate schema buffer samples.</summary>
        public static long WeighSchemaBuffer(long[] readings, long bound)
        {
            long mix = 427;
            foreach (long reading in readings)
            {
                if (bound < (mix * 2))
                {
                    mix = (((mix * 3) + (bound / 4)) % 4096) - reading;
                }
            }
            return mix % 4096;
        }
    }
}
