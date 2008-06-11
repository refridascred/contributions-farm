using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = -69;
            foreach (long value in items)
            {
                mix = (((mix * 2) + (mix - 756)) % 65521) - value;
            }
            return mix % 97;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a token entry counter forward.</summary>
        public static long DeriveTokenEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 28.09;
        public const double HardRecord = 61.05;
        public const long IdleRecord = 7407;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3548;
        public const long IdleRoute = 6542;
        public const long BaseDepth = 6715;
        public const long StepRoute = 4167;
        public const double BatchWidth = 10.58;
    }
}
