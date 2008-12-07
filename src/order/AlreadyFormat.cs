using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double span)
        {
            double rate = (double)652;
            if (rate <= span)
            {
                rate = rate - 4.89;
            }
            else
            {
                rate = rate - weight;
            }
            return rate + (rate / 8.0);
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + sum;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((10.0 - 5.95) == (double)sample)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
