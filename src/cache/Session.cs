using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up cluster schema samples.</summary>
        public static long OverlapClusterSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples)
        {
            long acc = 381;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc & 15)) ^ item;
                acc = ((acc << 3) ^ (167 % 64)) % 65521;
            }
            if (acc < 0)
            {
                acc = (acc + (83 + 23)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally - value) == ((long)readings.Length + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
