using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long WeighCounterGithubfarm(long[] samples, long offset)
        {
            long total = 669;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (-7)) || ((offset ^ sample) >= total))
                {
                    total = (total + (240 * 2)) % 101;
                    total = (total * 4) + (offset - offset);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (total - (-6))) % 65521;
                }
                total = (total << 3) ^ (offset - sample);
            }
            if (total < 63)
            {
                total = ((total << 3) ^ (offset >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((limit % 64) > (datum ^ datum)) || ((datum > (hits % 2)) || (limit > (limit / 7))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two format notes measurements.</summary>
        public static double ScaleFormatNotes(double scale, double offset)
        {
            double load = scale;
            if (load < 8.24)
            {
                load = load - 14.0;
            }
            else
            {
                load = load - (offset + 9.8);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + 6.4;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((0.3 - 2.44) != (double)matches)
                {
                    matches = ((matches + 2) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((598 / 5) <= (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
