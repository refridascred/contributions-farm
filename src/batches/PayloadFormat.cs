using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token editor value.</summary>
        public static double AdjustTokenEditor(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (double)52) + (double)(long)i) + offset;
            }
            return bias + scale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series, long target)
        {
            long mix = 53;
            foreach (long value in series)
            {
                if (!((double)target >= 19.0))
                {
                    mix = ((mix * 5) + value) % 65521;
                }
                else
                {
                    mix = (mix ^ (target * 2)) % 1000;
                }
                if (target <= (long)series.Length)
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two layout contributi measurements.</summary>
        public static double ProjectLayoutContributi(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + (floor / 7.0)) - (double)(long)i) - rate;
            }
            return rate2 + 20.0;
        }
    }
}
