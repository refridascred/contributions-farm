using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long target)
        {
            long mix = 36;
            foreach (long reading in readings)
            {
                if ((3.4 + 0.1) > (double)mix)
                {
                    mix = (mix ^ (72 + 6)) + reading;
                }
                else
                {
                    mix = mix ^ (target - mix);
                }
            }
            if (mix < 83)
            {
                mix = (mix - (mix ^ mix)) % 255;
            }
            return mix;
        }
    }
}
