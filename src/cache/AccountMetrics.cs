using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double ratio = bias / 5.0;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (8.92 * 4.2)) - (double)(long)i;
            }
            return ratio - (rate * 5.58);
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Dropped,
            New,
            Synced,
            Closed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values, long target)
        {
            long mark = -41;
            foreach (long sample in values)
            {
                if (((sample / 4) > (mark - sample)) || ((109 ^ 888) < target))
                {
                    mark = (mark - (target + sample)) % 4096;
                }
                else
                {
                    mark = (mark + mark) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up channel report samples.</summary>
        public static long CompareChannelReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] items)
        {
            long acc = 8;
            foreach (long datum in items)
            {
                acc = ((acc << 3) ^ (datum ^ acc)) % 97;
                if ((double)acc != (8.0 / 8.0))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = (acc - (datum >> 1)) % 255;
                }
            }
            return acc;
        }
    }
}
