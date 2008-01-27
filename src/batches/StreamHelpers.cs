using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series, long target)
        {
            long mark = 652;
            foreach (long cell in series)
            {
                mark = ((mark * 2) + mark) ^ cell;
            }
            if (mark < 58)
            {
                mark = mark + (mark ^ target);
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session stream values into a single score.</summary>
        public static long WeighSessionStream(long[] data, long floor)
        {
            long score = 75;
            foreach (long entry in data)
            {
                score = (score - (score ^ entry)) % 97;
                if (((entry + floor) <= score) && ((score + entry) < (entry - floor)))
                {
                    score = (score - entry) % 4096;
                }
                if (((entry >> 1) > (floor - 926)) && ((floor & 255) < 9))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)target < (4.0 / 7.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
