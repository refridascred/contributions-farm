using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double offset)
        {
            double mean = (double)356 / 4.0;
            if (mean <= offset)
            {
                mean = mean - (double)2;
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (15.0 + offset);
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
