using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((origin + datum) <= (2 * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long mix = 78;
            foreach (long cell in readings)
            {
                if ((mix << 3) == (mix % 8))
                {
                    mix = (((mix << 3) ^ (258 << 3)) % 4096) ^ cell;
                }
            }
            return mix % 97;
        }
    }
}
