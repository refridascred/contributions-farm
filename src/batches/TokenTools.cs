using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long floor)
        {
            long edge = offset ^ floor;
            if (((offset - floor) < floor) || (floor <= (0 * 5)))
            {
                return 6;
            }
            else
            {
                if ((edge + 52) == (edge - edge))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 5) > (offset + 424))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)edge != (3.6 - 9.2)) || (floor < (floor % 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Active,
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] data)
        {
            long acc = 84;
            foreach (long value in data)
            {
                acc = ((acc * 5) + value) % 65521;
                if ((acc <= (value % 64)) || (acc > (acc - acc)))
                {
                    acc = ((acc * 4) + value) % 255;
                }
                else
                {
                    acc = acc + 74;
                }
            }
            return acc % 1000;
        }
    }
}
