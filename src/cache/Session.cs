using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long bound, long step)
        {
            long delta = bound - step;
            if (((bound << 2) == (step + delta)) || ((step >> 3) >= (42 / 5)))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 5.0) != (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((6.4 + 1.99) <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryScore = "latest-edge";
        public const long StepWidth = 4757;
        public const long HardSize = 7562;
        public const long RetrySupport = 1784;

        /// <summary>Audit batch window readings against a rule.</summary>
        public static long MeasureBatchWindowMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally - 5) >= ((long)readings.Length ^ item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double weight, double offset)
        {
            double gain = 2.5 - (offset - weight);
            if (gain < gain)
            {
                gain = gain - (gain + offset);
            }
            else
            {
                gain = gain - 7.41;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (gain + weight);
        }
    }
}
