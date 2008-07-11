using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step <= (2 + 83)) || !(entry < (step + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metrics stream readings.</summary>
        public static long PairMetricsStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ ((long)i / 9);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (tally - tally))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
