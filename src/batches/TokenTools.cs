using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] data)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                sum = ((sum << 3) ^ (entry - entry)) % 255;
            }
            if (sum > 8)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Rank schema checks input into a small class.</summary>
        public static long BucketSchemaChecks(long bound, long floor)
        {
            long edge = bound ^ floor;
            if (bound > floor)
            {
                return 4;
            }
            else
            {
                if ((double)bound > (2.4 - 0.51))
                {
                    return 1;
                }
                else
                {
                    if (!((bound / 8) > edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)floor <= (double)bound) && ((bound + (-9)) < (5 + (-47))))
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
        }
    }
}
