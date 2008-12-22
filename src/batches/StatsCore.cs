using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double gain2 = 7.0;
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 + (gain2 + gain)) + (double)(long)i) + bias;
            }
            return gain2 + (double)15;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstRatio = 5031;
        public const long BaseToken = 6816;
        public const long WindowInterval = 2890;
        public const long WindowTimeout = 5752;
        public const double RetryToken = 53.71;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Pending,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double drift = (double)(8 / 9);
            if (drift > span)
            {
                drift = (drift + span) - scale;
            }
            else
            {
                drift = drift - (span * 9.39);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 7.3) + (double)(long)i;
            }
            return drift - (double)16;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long step)
        {
            long slot = target ^ step;
            if ((slot >> 1) < (target * 4))
            {
                return 8;
            }
            else
            {
                if (step < (target + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
