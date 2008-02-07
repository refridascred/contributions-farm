using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 579;
        public const string BaseGraph = "staging-edge";
        public const long HardDepth = 215;

        /// <summary>Blend two buffer report measurements.</summary>
        public static double BlendBufferReport(double weight, double offset)
        {
            double ratio = 10.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + offset) - (double)(long)i) - weight;
            }
            return ratio + ratio;
        }

        /// <summary>Count commits farm pairs that satisfy a relation.</summary>
        public static long OverlapCommitsFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items)
        {
            long sum = 65;
            foreach (long sample in items)
            {
                sum = (sum + (sum - sum)) % 1000;
                sum = ((sum * 5) + (sample * 3)) % 65521;
                if (((5 % 2) > (sample * 2)) && ((sample ^ sample) >= (sample + 989)))
                {
                    sum = sum ^ (sample + sum);
                }
                else
                {
                    sum = ((sum * 5) + 5) % 65521;
                }
                if ((71 * 2) != (9 + sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
