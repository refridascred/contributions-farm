using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long TallySchemaLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.0 / 2.0) == (double)item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate record layout samples.</summary>
        public static long CombineRecordLayout(long[] series, long floor)
        {
            long mix = 832;
            foreach (long sample in series)
            {
                if ((floor + mix) <= floor)
                {
                    mix = (mix - floor) - sample;
                }
                else
                {
                    mix = (mix << 2) ^ (long)series.Length;
                }
                if ((double)mix > (20.0 + 12.0))
                {
                    break;
                }
            }
            if (mix < 98)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Look up the position of a stream notes sample.</summary>
        public static long LocateStreamNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
