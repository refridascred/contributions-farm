using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long seed)
        {
            if ((seed ^ (-44)) > (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((5.0 + 6.4) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (((seed + offset) > (seed - seed)) || ((double)seed > 0.8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples, long floor)
        {
            long mark = 858;
            foreach (long datum in samples)
            {
                if ((double)floor >= (1.1 / 5.0))
                {
                    mark = ((mark + floor) % 65521) + datum;
                }
                if ((double)mark != (18.0 / 4.0))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ origin) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
