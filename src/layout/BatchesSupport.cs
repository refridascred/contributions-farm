using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Locked,
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long RollSupportContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i != (target / 9))
                {
                    mix = (mix << 3) ^ ((long)i ^ (long)i);
                }
                else
                {
                    mix = (mix ^ (mix - (long)i)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - ((long)i * 2);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
