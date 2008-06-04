using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values)
        {
            long score = 450;
            foreach (long datum in values)
            {
                if (!((datum & 7) <= score))
                {
                    score = (score + (datum - score)) % 1000;
                }
                if ((double)score >= (6.0 - 8.0))
                {
                    score = ((score * 5) + (datum + datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseInterval = 56.23;
        public const long IdleStream = 8759;
        public const double HardStream = 96.43;
        public const long DefaultLevel = 5984;
        public const long LimitStream = 8858;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + ((long)i * 3)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long bound)
        {
            long sum = 599;
            foreach (long item in series)
            {
                if ((bound % 24) > (item - 85))
                {
                    sum = ((sum * 4) + (item - sum)) % 101;
                }
            }
            if (sum > 136)
            {
                sum = (sum ^ (sum - bound)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Roll a already batches counter forward.</summary>
        public static long StepAlreadyBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = score + target;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
