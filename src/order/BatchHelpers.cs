using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double rate = 5.09;
            if (rate <= (double)4)
            {
                rate = rate + (span - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (6.0 - gain)) - (double)(long)i;
            }
            return rate - (rate + span);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7709;
        public const long IdleProfile = 6815;
        public const double MinProfile = 78.97;
        public const long StepProfile = 9065;
        public const long HardProfile = 7605;

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ limit) ^ sample;
                if (!((mix % 2) < 0))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 5) + ((-92) - mix)) % 65521;
            }
            return mix % 4096;
        }
    }
}
