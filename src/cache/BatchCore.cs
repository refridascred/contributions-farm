using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings)
        {
            long total = -985;
            foreach (long value in readings)
            {
                if (((total * 2) <= total) && ((18 & 127) <= (283 + value)))
                {
                    total = ((total << 2) ^ total) % 101;
                }
                else
                {
                    total = (total ^ ((-523) + total)) % 255;
                }
                if ((total << 3) < 9)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift + bias;
            }
            return drift - span;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long result = 533;
            foreach (long item in readings)
            {
                if (!((-8) >= (result & 3)))
                {
                    result = (result - result) % 1000;
                    result = result ^ item;
                }
                if (((floor >> 5) <= (item - item)) || ((double)result == (double)(long)readings.Length))
                {
                    result = (result + (result + floor)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches / 2) > (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
