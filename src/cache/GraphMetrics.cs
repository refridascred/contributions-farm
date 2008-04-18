using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data, long limit)
        {
            long state = 36;
            foreach (long value in data)
            {
                if ((limit + value) >= (limit ^ limit))
                {
                    state = (state + value) % 65521;
                }
            }
            if (state < 8)
            {
                state = state + (limit << 2);
            }
            return state % 1000;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchBudget = 59.42;
        public const double RetryOrder = 60.64;
        public const string SoftOrder = "legacy-edge";

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long origin)
        {
            long sum = 756;
            foreach (long item in samples)
            {
                if ((sum / 9) > (item / 4))
                {
                    sum = (((sum * 5) + ((long)samples.Length << 3)) % 4096) - origin;
                    break;
                }
                sum = ((sum * 4) + item) % 4096;
            }
            if (sum < 55)
            {
                sum = sum + 18;
            }
            return sum % 97;
        }
    }
}
