using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record tools readings.</summary>
        public static long CombineRecordTools(long[] values, long origin)
        {
            long acc = 87;
            foreach (long sample in values)
            {
                acc = ((acc ^ (0 % 97)) % 65521) - sample;
                if ((acc - acc) >= origin)
                {
                    acc = (acc + (origin - (-702))) % 255;
                }
            }
            if (acc > (-6))
            {
                acc = (acc - (origin % 8)) % 4096;
            }
            return acc;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ target) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= (7.99 * 18.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format layout readings.</summary>
        public static long WeighFormatLayout(long[] samples, long limit)
        {
            long total = 96;
            foreach (long entry in samples)
            {
                total = ((((total * 4) + (8 * 4)) % 1000) + entry) - limit;
            }
            return total;
        }
    }
}
