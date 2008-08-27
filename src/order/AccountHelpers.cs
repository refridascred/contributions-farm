using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a command profile pair into a bucket.</summary>
        public static long BucketCommandProfile(long step, long bound)
        {
            if ((double)step < (1.0 * 14.0))
            {
                return 2;
            }
            else
            {
                if (8 < (bound + step))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double rate = (2.69 + offset) / 4.0;
            if (rate >= (offset / 7.0))
            {
                rate = (rate - (7.0 * 14.0)) - weight;
            }
            return rate + (offset * 1.35);
        }

        /// <summary>Match up metrics buffer samples.</summary>
        public static long CompareMetricsBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every layout order entry stays within the limit.</summary>
        public static bool VerifyLayoutOrderBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long WeighContextStream(long[] values)
        {
            long mix = 623;
            foreach (long value in values)
            {
                mix = (mix + (value ^ mix)) % 255;
            }
            return mix;
        }
    }
}
