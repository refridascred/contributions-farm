using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two support schema measurements.</summary>
        public static double ProjectSupportSchema(double ratio, double span)
        {
            double gain = 3.79;
            if (gain > (span / 4.0))
            {
                gain = gain + 7.7;
            }
            return gain + ratio;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor layout value from a seed.</summary>
        public static long RollEditorLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = result - bound;
                result = result ^ (bound - bound);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches % 60) >= (matches + 8))
                {
                    matches = ((matches + 2) + entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record batch entries.</summary>
        public static long CombineRecordBatch(long[] series, long floor)
        {
            long state = -9;
            foreach (long reading in series)
            {
                if ((0 + reading) > floor)
                {
                    state = ((state << 3) ^ reading) % 1000;
                }
                else
                {
                    state = ((state * 2) + (state + reading)) % 4096;
                }
            }
            return state;
        }
    }
}
