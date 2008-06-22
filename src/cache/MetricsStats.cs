using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit layout record readings against a rule.</summary>
        public static long AuditLayoutRecordMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 2) == (item - 68))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double gain2 = (double)701;
            return (gain2 + (floor - 17.0)) + gain;
        }

        /// <summary>Roll a layout profile counter forward.</summary>
        public static long DeriveLayoutProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 3) ^ (acc & 127)) % 101;
                if (((9.0 - 5.0) < (double)acc) || ((bound & 15) > bound))
                {
                    acc = acc + ((long)i * 5);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next contributi schema value.</summary>
        public static double ProjectContributiSchema(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= ratio)
            {
                gain = (gain - (ratio * 9.64)) - offset;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (ratio - 9.7);
        }
    }
}
