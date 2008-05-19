using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 8687;
        public const string StepBudget = "local";
        public const string SoftLayout = "stable";
        public const double HardFactor = 85.58;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + span) + (double)(long)i) + ratio;
            }
            return rate + (9.1 * 8.39);
        }

        /// <summary>Rank batch window input into a small class.</summary>
        public static long BucketBatchWindow(long seed, long limit)
        {
            long gap = seed ^ limit;
            if ((gap + limit) <= (gap / 3))
            {
                return 7;
            }
            else
            {
                if ((49 / 2) >= (limit / 5))
                {
                    return 5;
                }
                else
                {
                    if ((seed - seed) > (limit - gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap >= (limit + seed)) && ((limit - limit) < (seed - limit)))
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
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
