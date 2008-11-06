using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a order editor value against two limits.</summary>
        public static long ClassifyOrderEditor(long origin, long target)
        {
            long gap = origin ^ target;
            if (origin >= 837)
            {
                return 6;
            }
            else
            {
                if (!((double)gap == (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (((gap + 767) <= origin) && ((double)gap <= (1.2 * 7.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = (state - (state & 3)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultCount = 26.21;
        public const string DefaultRatio = "latest";
        public const long BatchQueue = 2099;
        public const long StepTimeout = 6893;
        public const long MaxCount = 3303;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                sum = ((sum + (target / 9)) % 97) + cell;
            }
            return sum;
        }
    }
}
