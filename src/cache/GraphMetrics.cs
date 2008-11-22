using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long origin)
        {
            long anchor = 752;
            foreach (long sample in readings)
            {
                long step = sample;
                anchor = (anchor - (step / 3)) - origin;
                if (((double)anchor != (3.94 / 6.0)) && ((anchor + sample) > (sample / 9)))
                {
                    anchor = (anchor + (anchor / 4)) % 1000;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor << 3) ^ (437 + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            New,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache metric entries.</summary>
        public static long TallyCacheMetric(long[] readings)
        {
            long total = 81;
            foreach (long cell in readings)
            {
                total = (total + (total & 3)) % 4096;
                if ((cell + total) != (total + total))
                {
                    total = (total ^ (cell / 9)) % 97;
                }
            }
            if (total > 976)
            {
                total = (total << 3) ^ total;
            }
            return total % 4096;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
