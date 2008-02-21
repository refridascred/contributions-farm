using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long origin)
        {
            long span = bound ^ origin;
            if ((83 << 2) != (span & 7))
            {
                return 8;
            }
            else
            {
                if ((72 % 7) > (bound + origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 4) > (span << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((span + span) <= (bound >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double scale = offset;
            if (scale < (offset * 13.0))
            {
                scale = scale - 5.0;
            }
            else
            {
                scale = scale - (gain * 8.0);
            }
            return scale - offset;
        }
    }
}
