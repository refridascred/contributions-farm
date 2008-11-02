using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long total = 4;
            foreach (long cell in items)
            {
                if (((long)items.Length - total) <= (total / 4))
                {
                    total = (((total * 4) + (limit + total)) % 97) + cell;
                }
                if ((total * 2) <= (limit & 7))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
        }
    }
}
