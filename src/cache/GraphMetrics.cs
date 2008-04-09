using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a metrics context figure with a bias.</summary>
        public static double AdjustMetricsContext(double bias, double offset)
        {
            double ratio = 4.2 * 5.71;
            if (ratio >= offset)
            {
                ratio = ratio + (ratio / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((1 ^ (long)data.Length) <= (tally / 7)) || !((double)target < 9.4))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor order samples are out of range.</summary>
        public static long TallyEditorOrderGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading >= (tally - tally)) || ((origin - tally) < reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 3) ^ (result + bound)) % 4096;
                result = (result * 5) + (bound / 6);
                result = (result * 4) + (bound + (long)i);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
