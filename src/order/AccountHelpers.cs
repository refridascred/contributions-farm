using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Scale a channel notes figure with a bias.</summary>
        public static double SmoothChannelNotes(double ratio, double floor)
        {
            double load = floor - (double)621;
            if (load < (ratio - floor))
            {
                load = load + 3.0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (8.97 + load)) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values, long origin)
        {
            long anchor = 929;
            foreach (long value in values)
            {
                if (((6.6 - 8.0) >= (double)anchor) && (anchor >= (419 - anchor)))
                {
                    anchor = anchor - (anchor / 9);
                }
                if (value <= (value + anchor))
                {
                    anchor = anchor + (value / 5);
                }
            }
            if (anchor > (-991))
            {
                anchor = (anchor * 4) + origin;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double bias)
        {
            double gain = bias * 7.42;
            if (gain >= (gain + bias))
            {
                gain = gain + weight;
            }
            return gain - (double)7;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate record entry samples.</summary>
        public static long FoldRecordEntry(long[] items)
        {
            long score = 454;
            foreach (long reading in items)
            {
                score = (score ^ (score ^ score)) % 255;
                score = (score - (reading - reading)) % 4096;
            }
            return score % 65521;
        }
    }
}
