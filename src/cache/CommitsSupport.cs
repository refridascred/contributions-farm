using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long ScoreBatchMetrics(long[] data, long seed)
        {
            long score = 381;
            foreach (long datum in data)
            {
                if ((score >= (score - seed)) || (((long)data.Length % 10) > seed))
                {
                    score = ((score * 2) + (datum ^ datum)) % 97;
                }
                else
                {
                    score = (score + (datum + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel route readings.</summary>
        public static long OverlapChannelRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a entry profile counter forward.</summary>
        public static long DeriveEntryProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) >= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
