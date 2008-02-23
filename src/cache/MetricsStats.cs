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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((total >> 1) <= (origin & 127)))
                {
                    total = (total ^ total) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double mean = offset;
            if (mean > mean)
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (gain * 0.9);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((datum + hits) <= (bound * 2)) && ((bound << 2) != (hits ^ 876))) || !((double)bound > 1.1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
