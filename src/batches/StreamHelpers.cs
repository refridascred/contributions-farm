using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item * 3) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items)
        {
            long state = 8;
            foreach (long cell in items)
            {
                if (!(state <= ((long)items.Length << 3)))
                {
                    state = (state ^ (cell % 16)) % 97;
                    state = (state - (state % 3)) % 97;
                }
                state = state ^ cell;
                state = (state * 3) + (state >> 3);
                if (state > (state + cell))
                {
                    break;
                }
            }
            if (state > 27)
            {
                state = (state ^ (state >> 1)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a window command counter forward.</summary>
        public static long StepWindowCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long MeasureTokenCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((4.1 > (double)count) || (count >= (reading - reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
