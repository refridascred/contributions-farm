using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long seed)
        {
            long diff = origin - seed;
            if (((seed - origin) <= (28 * 2)) && (seed < diff))
            {
                return 8;
            }
            else
            {
                if ((743 - seed) >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < 6.4)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepSpan = 1151;
        public const double RetrySpan = 18.16;
        public const long BatchTools = 4511;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double drift = (span * 7.0) * 1.0;
            if (drift < (double)2)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (2.79 + drift);
            }
            return drift - (bias / 7.0);
        }
    }
}
