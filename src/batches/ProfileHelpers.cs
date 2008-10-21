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

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double weight = offset;
            if (weight > (offset * 2.5))
            {
                weight = weight - offset;
            }
            return weight + (17.0 + bias);
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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
