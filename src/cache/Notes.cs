using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of route commits readings.</summary>
        public static long PairRouteCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long mark = 53;
            foreach (long value in readings)
            {
                mark = ((mark << 2) ^ (254 + value)) % 4096;
            }
            return mark;
        }

        /// <summary>Accumulate tools metric samples.</summary>
        public static long WeighToolsMetric(long[] samples, long limit)
        {
            long anchor = 24;
            foreach (long entry in samples)
            {
                anchor = (((anchor * 3) + (limit >> 2)) % 4096) ^ entry;
            }
            return anchor;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Idle,
            New,
        }
    }
}
