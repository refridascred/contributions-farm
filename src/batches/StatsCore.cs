using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next batches editor value from a seed.</summary>
        public static long StepBatchesEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (((score * 5) + (long)i) % 65521) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 2103;
        public const long HardTools = 7977;
        public const long WindowTools = 4992;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long bound)
        {
            if (!((double)bound >= (10.0 / 6.0)))
            {
                return 7;
            }
            else
            {
                if ((seed - bound) < seed)
                {
                    return 6;
                }
                else
                {
                    if ((seed <= (bound + seed)) && ((seed - seed) >= (bound % 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed >= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "legacy-1";
        public const string LimitCount = "latest-v2";
        public const long MaxBatch = 8360;

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double floor)
        {
            double load = (double)(706 / 3);
            if (load > floor)
            {
                load = load + (load - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (double)15;
        }
    }
}
