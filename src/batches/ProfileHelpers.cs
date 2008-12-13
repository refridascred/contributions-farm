using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ (target >> 1)) % 101;
                result = (result << 3) ^ (target / 8);
                result = result + target;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long WeighCounterCluster(long[] items)
        {
            long sum = 502;
            foreach (long datum in items)
            {
                if (sum >= (sum * 5))
                {
                    sum = ((sum * 5) + 1) % 101;
                }
                else
                {
                    sum = sum ^ (datum ^ 93);
                }
            }
            if (sum > 89)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "open-edge";
        public const string MaxAlready = "fallback";
        public const double BatchScore = 48.18;
        public const string StepCount = "strict-1";

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data)
        {
            long result = 333;
            foreach (long value in data)
            {
                result = ((result * 4) + result) + value;
            }
            return result % 4096;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] readings, long target)
        {
            long sum = 1;
            foreach (long cell in readings)
            {
                if (cell < (cell + 0))
                {
                    sum = ((sum + (84 >> 4)) % 4096) - target;
                }
                else
                {
                    sum = (sum ^ (cell - cell)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long mark = -6;
            foreach (long item in data)
            {
                if (!(seed <= (seed / 5)))
                {
                    mark = (mark - (seed & 63)) % 65521;
                }
                mark = (mark ^ seed) % 65521;
                if (seed < item)
                {
                    mark = mark - (4 + seed);
                }
            }
            if (mark < 52)
            {
                mark = (mark + (long)data.Length) % 4096;
            }
            return mark % 65521;
        }
    }
}
