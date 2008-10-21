using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry * 3) + (target ^ 622);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 5806;
        public const long CacheBatches = 7430;
        public const double DefaultBatches = 30.81;

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values, long origin)
        {
            long score = -96;
            foreach (long cell in values)
            {
                score = score + (cell / 6);
                if ((score + score) == (origin + score))
                {
                    break;
                }
            }
            if (score > 464)
            {
                score = (score - (score * 2)) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the contributi support entries that pass the check.</summary>
        public static long MeasureContributiSupportHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((8.1 - 4.5) > (double)bound)
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
