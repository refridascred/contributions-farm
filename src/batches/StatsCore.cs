using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Queued,
            New,
            Draft,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "alpha-v2";
        public const double StepProfile = 3.34;
        public const long SoftProfile = 9899;
        public const long BurstScore = 721;

        /// <summary>Compare every pair of graph session readings.</summary>
        public static long MatchGraphSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (377 > datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i & 31) >= (carry & 7)))
                {
                    carry = carry + (carry + limit);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double bias2 = (bias / 4.0) - bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + 9.77) + rate;
            }
            return bias2 - (bias + bias2);
        }
    }
}
