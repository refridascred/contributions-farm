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

        /// <summary>Grade a already report value against two limits.</summary>
        public static long ClassifyAlreadyReport(long bound, long offset)
        {
            if (bound < (60 + bound))
            {
                return 5;
            }
            else
            {
                if ((bound - 29) != (bound + 1))
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ 8) >= offset) || ((bound - offset) < (bound - bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 4) != (offset << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
