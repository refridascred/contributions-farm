using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum / 7) >= (target << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double rate = span / 9.0;
            if (rate > (scale - span))
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate - span)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
