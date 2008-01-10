using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                anchor = anchor - cell;
                if ((anchor - cell) < (cell / 3))
                {
                    anchor = (anchor + (cell - cell)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double bias = (double)(4 % 24);
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - 15.0) - (double)(long)i) - offset;
            }
            return bias + ratio;
        }
    }
}
