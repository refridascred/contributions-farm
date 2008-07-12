using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long total = 731;
            foreach (long entry in samples)
            {
                total = (total * 5) + entry;
            }
            if (total > 0)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double span)
        {
            double load = span + span;
            if (load <= (double)1)
            {
                load = load + load;
            }
            else
            {
                load = load + (span - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (span - load)) + (double)(long)i;
            }
            return load + rate;
        }
    }
}
