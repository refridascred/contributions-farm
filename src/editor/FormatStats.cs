using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits <= cell)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double load = (double)(-38) / 6.0;
            if (load < (offset - 1.68))
            {
                load = (load + offset) + bias;
            }
            return load + (double)1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings)
        {
            long score = 828;
            foreach (long reading in readings)
            {
                score = ((score * 3) + (score - reading)) % 65521;
                if ((score % 60) < reading)
                {
                    break;
                }
            }
            if (score < 277)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                mark = (mark - (sample >> 5)) % 65521;
                if ((mark * 5) < ((long)levels.Length + sample))
                {
                    mark = mark + (mark ^ 442);
                }
                if (mark <= (sample << 1))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
