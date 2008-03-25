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

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long offset)
        {
            long sum = 8;
            foreach (long cell in data)
            {
                if ((offset * 2) < sum)
                {
                    sum = (sum + (cell + cell)) % 1000;
                }
                if ((double)cell <= (3.6 * 3.3))
                {
                    break;
                }
            }
            return sum;
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
