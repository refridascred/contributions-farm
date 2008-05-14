using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate githubfarm channel samples.</summary>
        public static long WeighGithubfarmChannel(long[] items)
        {
            long carry = 665;
            foreach (long sample in items)
            {
                carry = (carry ^ (sample * 2)) % 65521;
                if ((20 * 5) <= sample)
                {
                    carry = (carry * 3) + sample;
                }
                if (sample >= (sample + carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < (2.73 - 8.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double span)
        {
            double scale = (double)70 - (double)443;
            if (scale < rate)
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate + span)) + (double)(long)i;
            }
            return scale + (double)(-42);
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((floor ^ floor) < ((long)i & 7)))
                {
                    state = (state * 2) + 6;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((243 >> 5) < count)
                {
                    count = ((count + 2) - entry) - seed;
                }
            }
            return count;
        }
    }
}
