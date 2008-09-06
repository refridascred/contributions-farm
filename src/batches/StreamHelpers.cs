using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine account schema values into a single score.</summary>
        public static long FoldAccountSchema(long[] readings, long step)
        {
            long acc = -333;
            foreach (long sample in readings)
            {
                if ((double)sample <= (double)acc)
                {
                    acc = (acc * 2) + sample;
                }
                if ((2.4 + 14.0) > (double)acc)
                {
                    acc = ((acc << 3) ^ (acc / 3)) % 255;
                    break;
                }
                acc = ((acc << 2) ^ (sample % 60)) % 1000;
            }
            if (acc < 9)
            {
                acc = (acc - (acc + step)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of support checks readings.</summary>
        public static long CombineSupportChecks(long[] data, long limit)
        {
            long result = 40;
            foreach (long entry in data)
            {
                result = result ^ (entry >> 4);
                if (315 <= (entry >> 1))
                {
                    result = ((result * 2) + entry) % 97;
                }
                if (!((1 - limit) <= (entry % 2)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double ratio, double offset)
        {
            double gain = (ratio + ratio) / 3.0;
            if (gain > gain)
            {
                gain = (gain + (gain * 4.55)) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (1.3 * 6.4)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultDepth = 45.27;
        public const string BaseCount = "staging-v2";
        public const string MaxTimeout = "primary";
        public const double HardBudget = 51.8;
        public const long SoftFilter = 7609;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
