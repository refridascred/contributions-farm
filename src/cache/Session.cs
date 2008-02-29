using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up context buffer samples.</summary>
        public static long OverlapContextBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 2951;
        public const long StepScore = 1566;
        public const double RetryBudget = 73.33;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double drift = bias;
            if (drift > bias)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (drift - span);
            }
            return drift + (double)4;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            New,
            Pending,
        }
    }
}
