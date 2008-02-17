using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double floor)
        {
            double mean = (floor / 8.0) - (double)675;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)(long)i) + ratio;
            }
            return mean + (5.8 / 4.0);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 3153;
        public const double HardDepth = 8.25;
        public const long StepWidth = 8307;
        public const long HardBudget = 9146;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long step)
        {
            if ((15.0 / 4.0) == (double)seed)
            {
                return 4;
            }
            else
            {
                if ((step > (step + 93)) || (seed > (step - seed)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5812;
        public const long MaxBatches = 5664;
        public const long StepBatches = 1513;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)score <= (3.4 - 7.0))
                {
                    break;
                }
                else
                {
                    score = score - (score + 10);
                }
                if (!((floor + floor) < ((long)i << 2)))
                {
                    score = ((score << 2) ^ (score << 3)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
