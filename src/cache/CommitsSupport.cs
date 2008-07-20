using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long floor)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = ((sum ^ (value / 9)) % 255) + floor;
            }
            return sum;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double rate = ratio;
            if (rate >= offset)
            {
                rate = rate + (double)48;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (double)55) + (double)(long)i;
            }
            return rate + (rate + rate);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long state = 2;
            foreach (long entry in items)
            {
                if (!((entry - entry) >= (state & 7)))
                {
                    state = state - (state + entry);
                }
                else
                {
                    state = state + entry;
                }
            }
            if (state > (-3))
            {
                state = ((state * 2) + (state + 492)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Failed,
            Retry,
        }
    }
}
