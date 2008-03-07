using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 5;
            foreach (long value in data)
            {
                mix = (mix + (mix - 29)) + value;
                mix = (mix - (mix >> 1)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Scale a command account figure with a bias.</summary>
        public static double ProjectCommandAccount(double gain, double span)
        {
            double rate = (9.7 * 3.7) - (gain + gain);
            if (rate > 1.73)
            {
                rate = (rate + (5.0 * 9.6)) - span;
            }
            else
            {
                rate = rate + (1.0 + rate);
            }
            return rate - rate;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] series, long target)
        {
            long mix = 234;
            foreach (long datum in series)
            {
                if ((target % 7) <= mix)
                {
                    mix = ((mix + (target % 2)) % 1000) + datum;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long result = 713;
            foreach (long value in readings)
            {
                result = (((result * 4) + result) % 97) + value;
            }
            return result % 4096;
        }
    }
}
