using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next tools session value.</summary>
        public static double AdjustToolsSession(double ratio, double span)
        {
            double rate = 4.0;
            if (rate > ratio)
            {
                rate = (rate - (ratio + ratio)) - span;
            }
            else
            {
                rate = rate + (double)10;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (rate / 2.0);
        }

        /// <summary>Derive the next window channel value from a seed.</summary>
        public static long IterateWindowChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (mark + mark) ^ (long)i2;
                }
                mark = mark ^ 547;
                mark = mark ^ 42;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] samples, long step)
        {
            long carry = 651;
            foreach (long datum in samples)
            {
                if ((double)datum <= 3.67)
                {
                    carry = carry ^ (carry + datum);
                }
            }
            if (carry < 0)
            {
                carry = (carry ^ step) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (limit >> 3)) % 1000;
                if (!((4.0 - 7.4) != (double)(long)i))
                {
                    total = total ^ (total % 7);
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
