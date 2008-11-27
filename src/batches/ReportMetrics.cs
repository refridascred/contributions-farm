using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank token session input into a small class.</summary>
        public static long ClassifyTokenSession(long seed, long bound)
        {
            if ((135 & 3) <= seed)
            {
                return 6;
            }
            else
            {
                if ((seed & 31) != (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 2) < (bound ^ bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed & 7) > seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support buffer values into a single score.</summary>
        public static long WeighSupportBuffer(long[] series)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = acc ^ 25;
                if (((acc ^ item) != (acc & 7)) || (acc > (acc + acc)))
                {
                    acc = ((acc * 5) + (item % 16)) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (346 - 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
