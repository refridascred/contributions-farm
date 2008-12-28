using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double ratio, double floor)
        {
            double rate = (double)((-12) << 1);
            if (rate >= (double)5)
            {
                rate = rate + (ratio - 9.65);
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (floor * 19.0);
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double mean = bias * 1.8;
            return (mean + bias) + weight;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Stale,
            Paused,
            Queued,
        }
    }
}
