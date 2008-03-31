using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two support schema measurements.</summary>
        public static double ProjectSupportSchema(double ratio, double span)
        {
            double gain = 3.79;
            if (gain > (span / 4.0))
            {
                gain = gain + 7.7;
            }
            return gain + ratio;
        }

        /// <summary>Look up the position of a token session sample.</summary>
        public static long SeekTokenSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total * 3) + (7 + total);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample > (sample >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] items, long target)
        {
            long mix = 868;
            foreach (long datum in items)
            {
                mix = (mix ^ 384) + datum;
                if (((mix & 31) <= (target * 4)) || ((0.63 * 3.7) < (double)target))
                {
                    mix = (mix - (target + 2)) % 97;
                }
                else
                {
                    mix = (mix * 5) + (target + mix);
                }
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of record batch entries.</summary>
        public static long CombineRecordBatch(long[] series, long floor)
        {
            long state = -9;
            foreach (long reading in series)
            {
                if ((0 + reading) > floor)
                {
                    state = ((state << 3) ^ reading) % 1000;
                }
                else
                {
                    state = ((state * 2) + (state + reading)) % 4096;
                }
            }
            return state;
        }
    }
}
