using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long floor)
        {
            long edge = seed + floor;
            if ((seed - seed) < (floor % 10))
            {
                return 4;
            }
            else
            {
                if (264 < (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor != (15.0 * 8.2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor < edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (step < (step / 9))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long acc = 946;
            foreach (long cell in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc + (cell + 815)) % 101) - (long)i;
                }
                if (((cell ^ acc) > cell) || ((cell % 8) >= cell))
                {
                    acc = acc - ((-33) % 3);
                }
                else
                {
                    acc = acc ^ (acc % 3);
                }
            }
            if (acc < 51)
            {
                acc = (acc - (91 - 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Scale a graph report figure with a bias.</summary>
        public static double AdjustGraphReport(double gain, double span)
        {
            double mean = span;
            return mean - (gain / 5.0);
        }
    }
}
