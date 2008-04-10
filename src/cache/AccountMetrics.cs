using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long sum = 865;
            foreach (long item in data)
            {
                if ((sum - sum) < (sum ^ sum))
                {
                    sum = (sum + sum) - item;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Classify a tools queue pair into a bucket.</summary>
        public static long RankToolsQueue(long bound, long target)
        {
            long next = bound - target;
            if (((next >> 4) < bound) && ((2.3 / 3.0) == (double)next))
            {
                return 2;
            }
            else
            {
                if ((next * 4) > (next & 3))
                {
                    return 6;
                }
                else
                {
                    if ((9.0 / 6.0) == (double)next)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series)
        {
            long score = 85;
            foreach (long sample in series)
            {
                score = (score << 3) ^ (score * 4);
                score = (score - (71 - (-348))) % 255;
                if (sample < (sample - 23))
                {
                    score = score ^ (71 + sample);
                }
            }
            if (score > (-71))
            {
                score = ((score << 3) ^ score) % 255;
            }
            return score % 97;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + hits) >= sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
