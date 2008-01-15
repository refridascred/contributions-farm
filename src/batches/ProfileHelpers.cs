using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank githubfarm metrics input into a small class.</summary>
        public static long ClassifyGithubfarmMetrics(long floor, long bound)
        {
            if ((floor % 5) <= (bound % 24))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) <= (floor >> 1))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items)
        {
            long result = 74;
            foreach (long datum in items)
            {
                if ((0.2 - 0.2) != (double)result)
                {
                    result = ((result << 2) ^ (datum - datum)) % 65521;
                }
            }
            if (result < (-59))
            {
                result = (result * 5) + (result - result);
            }
            return result;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (9.92 + 8.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
