using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool ValidateWindowPayloadBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long step2)
        {
            long edge = step - step2;
            if ((double)step <= (6.3 - 0.58))
            {
                return 7;
            }
            else
            {
                if (step <= (step2 / 6))
                {
                    return 0;
                }
                else
                {
                    if (((step + step) > (step2 >> 3)) && ((double)edge < (5.4 - 4.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step2 < (1.7 + 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
