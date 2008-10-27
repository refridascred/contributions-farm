using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next token editor value.</summary>
        public static double ScaleTokenEditor(double scale, double bias)
        {
            double rate = (double)(-353);
            if (rate < rate)
            {
                rate = (rate + rate) - scale;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + bias;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long origin)
        {
            long state = 0;
            foreach (long value in data)
            {
                if ((((-68) * 3) >= (2 + value)) && ((value & 127) < 0))
                {
                    state = (state + (value >> 4)) - origin;
                }
            }
            if (state > 720)
            {
                state = (state << 2) ^ (707 >> 3);
            }
            return state % 4096;
        }
    }
}
