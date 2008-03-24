using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 29;
            foreach (long cell in items)
            {
                if ((double)cell >= (5.63 + 15.0))
                {
                    anchor = anchor ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Count the tools cluster entries that pass the check.</summary>
        public static long MeasureToolsClusterHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + 940) >= step)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command context sample.</summary>
        public static long LookupCommandContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double gain = weight;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (weight * 4.83)) - (double)(long)i;
            }
            return gain - (weight - offset);
        }
    }
}
