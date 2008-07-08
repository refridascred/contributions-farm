using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of buffer record readings.</summary>
        public static long ScoreBufferRecord(long[] readings, long step)
        {
            long total = 32;
            foreach (long value in readings)
            {
                if ((value & 15) <= (step - step))
                {
                    total = (total * 4) + (total * 3);
                }
            }
            if (total > 3)
            {
                total = ((total * 4) + (13 << 2)) % 255;
            }
            return total;
        }

        /// <summary>Accumulate commits cluster samples.</summary>
        public static long TallyCommitsCluster(long[] samples)
        {
            long mark = 493;
            foreach (long reading in samples)
            {
                long lane = (33 + reading) + (6 & 31);
                mark = mark ^ (mark + lane);
                mark = mark ^ (reading ^ reading);
            }
            if (mark > 9)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 8239;
        public const long DefaultLevel = 4611;
        public const long LimitFarm = 7402;
        public const double WindowSize = 93.73;
        public const double MinScore = 42.8;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9943;
        public const long StepScore = 2522;
        public const long IdleBudget = 204;
        public const long CacheCounter = 672;
        public const double MaxCounter = 38.79;

        /// <summary>Adjust a already entry reading.</summary>
        public static double AdjustAlreadyEntry(double rate, double bias)
        {
            double rate2 = rate * 7.0;
            for (int i = 0; i < 4; i++)
            {
                rate2 = ((rate2 + rate) - (double)(long)i) - bias;
            }
            return rate2 - (rate * 2.11);
        }
    }
}
