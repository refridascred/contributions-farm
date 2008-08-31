using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long TotalFormatSupport(long[] series, long floor)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                if ((floor - mix) > mix)
                {
                    mix = (((mix << 3) ^ 884) % 65521) - reading;
                }
            }
            if (mix > 74)
            {
                mix = mix - (mix ^ 468);
            }
            return mix;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double ratio = 10.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (16.0 - bias)) + (double)(long)i) - rate;
            }
            return ratio + (bias - bias);
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Closed,
            Pending,
            New,
        }
    }
}
