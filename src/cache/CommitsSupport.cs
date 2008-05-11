using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch cluster input into a small class.</summary>
        public static long RankBatchCluster(long bound, long floor)
        {
            long slot = bound + floor;
            if ((bound + floor) < (slot << 1))
            {
                return 4;
            }
            else
            {
                if ((slot + floor) != (slot << 1))
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) >= (floor ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload record readings.</summary>
        public static long WeighPayloadRecord(long[] readings, long step)
        {
            long state = 0;
            foreach (long cell in readings)
            {
                if ((state ^ cell) < (state - cell))
                {
                    state = (state + (1 * 3)) % 1000;
                    state = (state + (state + step)) % 4096;
                }
                state = (state + (state >> 5)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double bias2 = 2.6 * 1.04;
            return ((bias2 + (bias2 * 6.66)) + scale) + bias;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((0 >> 5) < (32 - tally))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context metrics samples.</summary>
        public static long CombineContextMetrics(long[] series)
        {
            long result = 7;
            foreach (long sample in series)
            {
                result = result ^ (sample + result);
                result = (result + (result >> 1)) % 65521;
            }
            if (result < 8)
            {
                result = result + (result - result);
            }
            return result;
        }
    }
}
