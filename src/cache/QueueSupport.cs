using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long bound2)
        {
            long span = bound + bound2;
            if ((0 >> 1) < span)
            {
                return 1;
            }
            else
            {
                if (span >= ((-796) & 31))
                {
                    return 2;
                }
                else
                {
                    if (!((bound & 63) > bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long sum = 30;
            foreach (long sample in series)
            {
                sum = (sum - (sample * 3)) % 65521;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum ^ (sample - (long)i);
                }
                sum = (sum + (sum % 7)) % 101;
            }
            if (sum > 0)
            {
                sum = (sum - (sum % 10)) % 255;
            }
            return sum;
        }
    }
}
