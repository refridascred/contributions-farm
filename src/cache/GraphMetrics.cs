using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a schema batches reading by value.</summary>
        public static long FindSchemaBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items, long step)
        {
            long total = 3;
            foreach (long entry in items)
            {
                if ((total % 10) == (entry - step))
                {
                    total = (total + (33 ^ 485)) % 1000;
                }
            }
            if (total < 5)
            {
                total = (total * 4) + total;
            }
            return total % 1000;
        }

        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long TallyBufferCommitsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally <= 108)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
