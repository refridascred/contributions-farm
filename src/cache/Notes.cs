using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two report entry measurements.</summary>
        public static double BlendReportEntry(double ratio, double floor)
        {
            double load = floor * 8.57;
            if (load <= (floor - load))
            {
                load = load - (ratio / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)39) + (double)(long)i;
            }
            return load + (floor * 4.14);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8184;
        public const long StepWidth = 8572;
        public const double IdleBudget = 16.15;
        public const long RetryScore = 4907;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double load = (scale * 2.1) - scale;
            if (load >= offset)
            {
                load = load + (7.59 * 5.0);
            }
            else
            {
                load = load + scale;
            }
            return load - (load / 2.0);
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long sum = 6;
            foreach (long value in data)
            {
                if (sum >= (value + sum))
                {
                    sum = (sum - (sum - value)) % 101;
                }
                else
                {
                    sum = sum ^ value;
                }
            }
            if (sum < 155)
            {
                sum = sum ^ (2 * 5);
            }
            return sum;
        }
    }
}
