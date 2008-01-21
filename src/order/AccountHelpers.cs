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

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = (((state - (55 + state)) % 4096) ^ item) + limit;
                if ((2.7 > (7.5 - 6.0)) && ((8.41 / 3.0) >= (double)(long)levels.Length))
                {
                    break;
                }
            }
            return state;
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
