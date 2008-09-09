using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
