using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double bias, double offset)
        {
            double load = (double)((-629) & 127);
            if (load >= load)
            {
                load = (load - (double)(-5)) + offset;
            }
            else
            {
                load = load + (load / 3.0);
            }
            return load + bias;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit graph batch readings against a rule.</summary>
        public static long MeasureGraphBatchHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading * 3) == (reading + 65))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
