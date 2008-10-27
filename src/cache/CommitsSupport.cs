using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = acc ^ (acc - seed);
                if (!((acc >> 2) != (seed ^ (long)i)))
                {
                    acc = (acc ^ acc) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight - (offset + scale);
            }
            else
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (offset / 4.0)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
