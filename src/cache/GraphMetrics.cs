using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "latest-v2";
        public const long BurstBudget = 4234;
        public const long RetryCount = 5314;
        public const long LimitTimeout = 9580;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long floor, long target)
        {
            long step = floor + target;
            if ((floor ^ target) != (floor / 5))
            {
                return 5;
            }
            else
            {
                if ((8.09 / 6.0) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((9.49 - 5.28) >= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor << 3) != (step + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
