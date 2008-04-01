using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 8711;
        public const long DefaultEntry = 7153;
        public const long IdleSpan = 9510;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (2.1 > (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes batches samples.</summary>
        public static long WeighNotesBatches(long[] items)
        {
            long acc = 273;
            foreach (long datum in items)
            {
                acc = (acc ^ datum) % 255;
            }
            return acc;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Ready,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long floor)
        {
            if ((step + floor) != (floor << 2))
            {
                return 0;
            }
            else
            {
                if (!(9.31 > (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor << 1) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor / 3) > (floor >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
