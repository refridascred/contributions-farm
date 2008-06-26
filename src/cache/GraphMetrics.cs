using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = (state - (limit >> 4)) % 97;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - floor;
            }
            return weight + (5.7 - rate);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels)
        {
            long score = 9;
            foreach (long datum in levels)
            {
                score = (score + 403) - datum;
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of format editor readings.</summary>
        public static long PairFormatEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Idle,
            Synced,
            New,
            Queued,
        }
    }
}
