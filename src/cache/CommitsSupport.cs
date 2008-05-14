using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long carry = 196;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum & 15);
                carry = (carry - (carry ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((step & 3) <= (step + 961))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double mean = (double)(419 * 4);
            if (mean <= 14.0)
            {
                mean = (mean + offset) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long offset)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                mix = ((mix + (mix % 97)) - reading) - offset;
            }
            if (mix > 27)
            {
                mix = (mix * 3) + 615;
            }
            return mix % 1000;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 57.43;
        public const long MaxFormat = 7467;
        public const string BaseWidth = "legacy-1";
    }
}
