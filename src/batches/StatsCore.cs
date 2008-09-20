using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long target)
        {
            long score = 33;
            foreach (long entry in items)
            {
                if (!((score - entry) == (entry + entry)))
                {
                    score = ((score << 2) ^ (entry % 97)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (target ^ entry)) % 1000;
                }
                if ((1 ^ target) <= (entry << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double scale = (rate * 1.0) - (rate / 7.0);
            if (scale > scale)
            {
                scale = scale + (scale + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale + (scale - scale);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry + (carry / 5)) % 101;
                if ((18.0 <= (double)carry) || ((double)(long)i >= (8.0 / 7.0)))
                {
                    carry = (carry - (carry * 3)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 50.48;
        public const long BurstContributi = 8501;
        public const long MaxBudget = 3030;
        public const double IdleSpan = 17.02;
        public const long MinFactor = 1914;

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "strict-1";
        public const double BaseFarm = 7.19;
        public const long SoftWidth = 3726;
        public const double DefaultFarm = 31.56;
        public const long BatchFarm = 1845;
    }
}
