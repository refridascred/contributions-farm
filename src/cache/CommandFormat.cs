using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value & 15) == (value << 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values)
        {
            long state = 1;
            foreach (long datum in values)
            {
                state = ((state << 2) ^ (datum ^ datum)) % 1000;
                if ((18.0 * 9.25) >= (double)state)
                {
                    state = (state - (state + (long)values.Length)) % 1000;
                }
                if (!((datum - state) > 650))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count ^ 28) <= count))
                {
                    count = ((count + 3) - value) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double weight = rate - 9.7;
            if (weight > (span * 6.18))
            {
                weight = weight - (weight / 3.0);
            }
            return weight + rate;
        }
    }
}
