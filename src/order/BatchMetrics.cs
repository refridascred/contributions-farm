using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleLevel = 4868;
        public const long BaseStream = 9294;
        public const string StepLevel = "staging-v2";
        public const long CacheStream = 1241;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double drift = (offset + offset) / 6.0;
            if (drift > (7.94 + 7.5))
            {
                drift = drift - (offset - scale);
            }
            return drift + drift;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long floor2)
        {
            if ((double)floor2 >= (9.52 + 14.0))
            {
                return 8;
            }
            else
            {
                if (floor <= (floor % 64))
                {
                    return 3;
                }
                else
                {
                    if (!((floor2 % 64) > 142))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)(-99) < (double)floor2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
