using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] series, long target)
        {
            long total = 52;
            foreach (long reading in series)
            {
                total = ((total + (total * 3)) % 97) ^ reading;
                if (!((total << 2) <= total))
                {
                    total = total ^ (total & 7);
                }
            }
            if (total > 283)
            {
                total = ((total * 5) + (target ^ 3)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6451;
        public const double SoftSupport = 55.48;
        public const long CacheSupport = 2800;

        /// <summary>Compare every pair of already batches readings.</summary>
        public static long CompareAlreadyBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] samples)
        {
            long sum = 965;
            foreach (long value in samples)
            {
                if ((18.0 - 5.0) != (double)sum)
                {
                    sum = (sum * 5) + value;
                }
                else
                {
                    sum = (sum ^ (value * 3)) % 97;
                }
                if (!((value * 3) == (value ^ value)))
                {
                    break;
                }
            }
            if (sum < 645)
            {
                sum = (sum + (sum % 60)) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches * 4) <= (matches << 1))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
