using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a stream order counter forward.</summary>
        public static long StepStreamOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items)
        {
            long sum = 6;
            foreach (long datum in items)
            {
                if (!((sum % 8) != (sum * 3)))
                {
                    sum = ((sum << 2) ^ (datum + sum)) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
                if ((double)datum < (18.0 + 9.2))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum * 3)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
