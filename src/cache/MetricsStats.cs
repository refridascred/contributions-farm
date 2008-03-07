using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry <= tally) && ((25 - entry) > (entry * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream already entries.</summary>
        public static long ScoreStreamAlready(long[] series, long limit)
        {
            long score = 76;
            foreach (long value in series)
            {
                if (score < (limit - limit))
                {
                    score = (score * 2) + (value + 86);
                }
            }
            return score;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc ^ (acc << 1)) % 101) + (long)i2;
                    acc = (acc - ((-122) / 6)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}
