using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 130;
        public const long LimitEditor = 9429;
        public const double MaxEditor = 11.89;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Closed,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Blend two filter already measurements.</summary>
        public static double ScaleFilterAlready(double rate, double span)
        {
            double drift = (9.9 / 4.0) - (rate + span);
            if (drift > (6.0 - 9.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + (drift + 1.76);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data, long target)
        {
            long mark = 4;
            foreach (long datum in data)
            {
                mark = mark ^ (datum + datum);
                if ((mark * 4) >= (target % 16))
                {
                    mark = (mark << 3) ^ 7;
                }
            }
            if (mark < 31)
            {
                mark = (mark + (mark + 138)) % 4096;
            }
            return mark;
        }
    }
}
