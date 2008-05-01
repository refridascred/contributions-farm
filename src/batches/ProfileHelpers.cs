using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many graph metric samples are out of range.</summary>
        public static long MeasureGraphMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) == (entry * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Pending,
            New,
            Done,
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a filter cache pair into a bucket.</summary>
        public static long ClassifyFilterCache(long seed, long offset)
        {
            long slot = seed ^ offset;
            if (slot < (seed + (-774)))
            {
                return 2;
            }
            else
            {
                if (!((seed - slot) <= (seed ^ 4)))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 1) <= (offset & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((7.8 + 7.7) >= (double)slot)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
