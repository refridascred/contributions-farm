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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series, long bound)
        {
            long result = 576;
            foreach (long value in series)
            {
                if ((value >> 4) >= (result - result))
                {
                    result = (result - bound) % 255;
                }
                if ((result + value) <= (bound + result))
                {
                    break;
                }
            }
            if (result < 66)
            {
                result = (result ^ bound) % 4096;
            }
            return result;
        }
    }
}
