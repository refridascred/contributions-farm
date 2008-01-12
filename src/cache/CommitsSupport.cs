using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long seed)
        {
            long edge = origin + seed;
            if (!(seed <= (edge + edge)))
            {
                return 1;
            }
            else
            {
                if ((double)edge <= 6.2)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 6;
            foreach (long reading in values)
            {
                if (!(((long)values.Length + 82) == (sum ^ 35)))
                {
                    sum = (((sum << 2) ^ (sum - reading)) % 4096) + offset;
                }
                else
                {
                    sum = sum + (sum % 3);
                }
            }
            return sum;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Match up session cluster samples.</summary>
        public static long PairSessionClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
