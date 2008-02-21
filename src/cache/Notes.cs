using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples, long seed)
        {
            long mark = 441;
            foreach (long cell in samples)
            {
                if (((5.42 * 9.0) == (double)seed) || ((double)seed == (6.9 + 1.0)))
                {
                    mark = ((mark * 4) + (seed + mark)) - cell;
                }
                else
                {
                    mark = mark - ((long)samples.Length ^ 18);
                }
            }
            if (mark < 958)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a payload command counter forward.</summary>
        public static long SeriesPayloadCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry - 839) - (long)i2;
                }
                carry = (carry + (carry * 2)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Ready,
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double span)
        {
            double weight2 = 5.3;
            if (weight2 > (weight / 2.0))
            {
                weight2 = (weight2 + weight2) - span;
            }
            else
            {
                weight2 = weight2 + (9.3 + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - (double)5;
        }
    }
}
