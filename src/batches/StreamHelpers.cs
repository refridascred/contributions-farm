using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Pending,
            Draft,
        }

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

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            New,
            Pending,
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
