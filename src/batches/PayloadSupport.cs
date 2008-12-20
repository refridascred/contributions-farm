using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double offset)
        {
            double load = offset;
            if (load <= 3.68)
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load + bias)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long floor)
        {
            long total = 50;
            foreach (long reading in series)
            {
                total = (total * 2) + ((long)series.Length - reading);
            }
            if (total < 5)
            {
                total = ((total * 5) + floor) % 101;
            }
            return total;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
