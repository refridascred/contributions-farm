using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double rate = offset;
            if (rate >= (offset / 7.0))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + ratio;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Queued,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if (9 >= (floor << 1))
                {
                    anchor = (anchor + ((long)i ^ anchor)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
