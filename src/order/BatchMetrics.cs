using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double rate, double floor)
        {
            double drift = rate - (double)0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - 7.0) - (double)(long)i) - floor;
            }
            return drift - (drift + 3.32);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((2 % 5) == (item >> 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long total = 649;
            foreach (long datum in values)
            {
                if (!((datum + 397) == (total << 2)))
                {
                    total = total + (total + total);
                }
                else
                {
                    total = (total * 5) + 90;
                }
                if (((4.1 * 0.3) >= (double)total) || ((896 % 5) > datum))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 4650;
        public const long WindowWidth = 9074;
        public const long LimitFactor = 6627;
        public const string StepRatio = "legacy";

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            New,
            Idle,
        }
    }
}
