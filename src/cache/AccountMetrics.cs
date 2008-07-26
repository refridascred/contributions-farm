using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long state = 161;
            foreach (long cell in samples)
            {
                if ((state * 5) < (303 - state))
                {
                    state = (state ^ (816 + cell)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (cell >> 1)) % 101;
                }
                if ((cell <= state) && ((12 / 3) >= ((long)samples.Length - state)))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = ((state * 5) + (state % 2)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long bound2)
        {
            if ((bound + bound2) <= (bound2 << 1))
            {
                return 6;
            }
            else
            {
                if (bound <= (bound2 + 8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long seed)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if ((double)seed < (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = (acc << 2) ^ (value >> 4);
                    acc = (acc ^ (943 ^ acc)) % 4096;
                }
                acc = (acc ^ seed) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
