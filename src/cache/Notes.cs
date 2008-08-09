using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two report entry measurements.</summary>
        public static double BlendReportEntry(double ratio, double floor)
        {
            double load = floor * 8.57;
            if (load <= (floor - load))
            {
                load = load - (ratio / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)39) + (double)(long)i;
            }
            return load + (floor * 4.14);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((31 - floor) != (floor + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long seed)
        {
            long sum = 2;
            foreach (long reading in values)
            {
                sum = (((sum * 4) + 786) % 4096) - reading;
                if ((5.0 - 4.87) < (double)seed)
                {
                    sum = (sum ^ (seed + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long sum = 6;
            foreach (long value in data)
            {
                if (sum >= (value + sum))
                {
                    sum = (sum - (sum - value)) % 101;
                }
                else
                {
                    sum = sum ^ value;
                }
            }
            if (sum < 155)
            {
                sum = sum ^ (2 * 5);
            }
            return sum;
        }
    }
}
