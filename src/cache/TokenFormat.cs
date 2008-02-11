using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Ready,
            Dropped,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long step)
        {
            long prev = floor ^ step;
            if (!(prev < floor))
            {
                return 1;
            }
            else
            {
                if (step > (step & 255))
                {
                    return 3;
                }
                else
                {
                    if (step <= (floor ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values)
        {
            long anchor = 53;
            foreach (long sample in values)
            {
                if ((7.6 * 11.0) >= (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (38 % 8)) % 97;
                }
                if (!(sample >= (anchor + sample)))
                {
                    anchor = anchor + (sample * 2);
                }
                if (((anchor << 2) < (-72)) && ((sample * 5) >= (617 + sample)))
                {
                    anchor = ((anchor * 4) + sample) % 255;
                }
                else
                {
                    anchor = anchor ^ sample;
                }
            }
            return anchor;
        }
    }
}
