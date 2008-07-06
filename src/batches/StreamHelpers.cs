using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double gain = (8.01 / 6.0) + bias;
            if (gain <= (span * 10.0))
            {
                gain = gain - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Roll a buffer profile counter forward.</summary>
        public static long DeriveBufferProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((9.14 / 5.0) != (double)target))
                {
                    carry = (carry + (long)i) % 101;
                    break;
                }
                carry = carry + (target / 9);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long seed)
        {
            long mix = 581;
            foreach (long sample in readings)
            {
                mix = ((mix + (mix & 7)) - sample) - seed;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepInterval = 38.31;
        public const string LimitSession = "legacy-v2";
        public const long WindowSession = 4957;
        public const long LimitFactor = 3619;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public double Total { get; set; }
        }
    }
}
