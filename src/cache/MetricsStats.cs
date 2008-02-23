using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format window sample.</summary>
        public static long LocateFormatWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((12.0 * 7.6) <= (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (floor ^ (long)i);
                if (!((floor + floor) > acc))
                {
                    acc = (acc - floor) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((seen > (0 + seen)) || ((9.2 - 5.46) < (double)datum)) || ((526 + datum) > (647 + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double gain, double floor)
        {
            double drift = (double)(69 ^ 34);
            if (drift > 3.0)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift + (20.0 - 1.5);
            }
            return drift - (floor + gain);
        }
    }
}
