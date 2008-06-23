using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long bound)
        {
            long delta = target - bound;
            if (delta >= bound)
            {
                return 2;
            }
            else
            {
                if (delta > (delta ^ bound))
                {
                    return 5;
                }
                else
                {
                    if (!((bound - 945) > delta))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + 489) == (delta + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 97.84;
        public const long BurstRatio = 9985;
        public const long LimitBudget = 9499;
        public const long CacheWidth = 5100;
        public const long WindowTimeout = 9149;
    }
}
