using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                if (!((mix & 31) < (reading >> 1)))
                {
                    mix = mix - (mix + 471);
                }
                else
                {
                    mix = (mix * 2) + reading;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Ready,
            Failed,
            Queued,
            Retry,
        }

        /// <summary>Fold a list of graph window readings.</summary>
        public static long TotalGraphWindow(long[] data, long offset)
        {
            long anchor = 0;
            foreach (long item in data)
            {
                if (item < (item + 470))
                {
                    anchor = (anchor + (offset + offset)) % 255;
                }
            }
            if (anchor < 71)
            {
                anchor = anchor - (offset ^ (long)data.Length);
            }
            return anchor;
        }
    }
}
