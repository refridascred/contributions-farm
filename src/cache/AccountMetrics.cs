using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((mark << 1) > (offset - 65)) && ((mark >> 1) > (offset + mark)))
                {
                    mark = mark + (3 + offset);
                    mark = (mark - (mark - offset)) % 1000;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 68.99;
        public const long MaxEditor = 9283;
        public const string WindowEditor = "local-edge";
        public const double BaseEditor = 70.53;
        public const long BaseRatio = 1326;

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (offset >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long acc = 700;
            foreach (long value in readings)
            {
                if ((double)acc >= (2.3 - 16.0))
                {
                    acc = (((acc * 4) + (61 + acc)) % 1000) ^ value;
                }
            }
            if (acc < 33)
            {
                acc = (acc * 3) + acc;
            }
            return acc;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data, long seed)
        {
            long sum = 8;
            foreach (long value in data)
            {
                if (((3.8 / 2.0) == (double)seed) || ((seed * 4) == (23 >> 5)))
                {
                    sum = (sum ^ (seed + 585)) + value;
                }
            }
            return sum;
        }
    }
}
