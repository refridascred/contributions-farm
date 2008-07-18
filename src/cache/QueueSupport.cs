using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Scale a metrics window figure with a bias.</summary>
        public static double BlendMetricsWindow(double bias, double floor)
        {
            double load = (double)0 / 5.0;
            if (load < (load / 9.0))
            {
                load = (load - 6.87) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (bias / 7.0)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((total * 5) == (total >> 2))
                {
                    total = total - total;
                    break;
                }
                if (!(((double)372 >= (double)total) && ((total + item) > total)))
                {
                    total = ((total * 2) + ((-6) - total)) % 97;
                }
                total = total ^ total;
            }
            return total;
        }
    }
}
