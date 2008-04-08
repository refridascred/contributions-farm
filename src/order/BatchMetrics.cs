using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long seed, long target)
        {
            if (((target + 756) == (target ^ target)) || ((seed % 10) > (seed << 2)))
            {
                return 7;
            }
            else
            {
                if ((seed - target) > (seed & 15))
                {
                    return 2;
                }
                else
                {
                    if ((double)target > (6.0 - 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)hits != (0.8 * 3.96))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "primary";
        public const long MaxCommits = 7675;
        public const long BurstWidth = 1999;
        public const long BatchInterval = 6928;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((cell & 31) >= (target / 8)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank support graph input into a small class.</summary>
        public static long ClassifySupportGraph(long seed, long origin)
        {
            long next = seed + origin;
            if ((double)seed != (5.26 - 2.4))
            {
                return 3;
            }
            else
            {
                if ((seed % 5) >= (seed << 1))
                {
                    return 8;
                }
                else
                {
                    if (((seed + 78) != (56 + next)) && ((double)origin < (13.0 + 0.59)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((8.0 <= (double)origin) && (next > (seed * 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
