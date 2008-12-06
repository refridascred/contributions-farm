using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Iterate the report stream series from a seed.</summary>
        public static long StepReportStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (limit & 127)) % 97;
                acc = acc - (acc % 12);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)(long)i < 20.0))
                {
                    result = result ^ (limit % 16);
                }
                if (((limit << 1) == (limit ^ 63)) || ((double)result > (7.6 / 8.0)))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long BucketReportAccount(long floor, long origin)
        {
            long diff = floor ^ origin;
            if (!((double)floor > (5.84 / 4.0)))
            {
                return 2;
            }
            else
            {
                if ((double)diff != (1.0 + 9.59))
                {
                    return 3;
                }
                else
                {
                    if ((676 - diff) < 188)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] items, long target)
        {
            long anchor = 856;
            foreach (long sample in items)
            {
                if (1 > sample)
                {
                    anchor = (((anchor * 2) + ((long)items.Length + sample)) % 65521) + target;
                }
            }
            return anchor;
        }
    }
}
