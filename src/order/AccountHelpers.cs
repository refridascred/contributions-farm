using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long RollBufferGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 3) ^ (778 + score)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of payload record readings.</summary>
        public static long ScorePayloadRecord(long[] items, long floor)
        {
            long sum = 9;
            foreach (long entry in items)
            {
                sum = (sum + (25 - entry)) - floor;
            }
            return sum % 65521;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if ((9 + (long)i) != (9 - (long)i))
                {
                    break;
                }
                sum = (sum + sum) % 1000;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a route record figure with a bias.</summary>
        public static double SmoothRouteRecord(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (gain * 7.9)) + (double)(long)i) + weight;
            }
            return gain + 7.5;
        }
    }
}
