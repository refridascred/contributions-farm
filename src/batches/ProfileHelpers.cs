using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinBudget = 19.9;
        public const string BurstRatio = "stable-edge";
        public const double DefaultSpan = 56.59;
        public const string StepFilter = "strict-edge";

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long WeighNotesFilter(long[] series)
        {
            long mix = 665;
            foreach (long reading in series)
            {
                mix = ((mix + (0 * 3)) % 1000) + reading;
                mix = (mix + 1) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long seed, long origin)
        {
            if ((double)origin == (8.7 / 5.0))
            {
                return 4;
            }
            else
            {
                if (origin <= (origin ^ seed))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of context contributi readings.</summary>
        public static long PairContextContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Stale,
            Dropped,
            Locked,
            Done,
        }
    }
}
