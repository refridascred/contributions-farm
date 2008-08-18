using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long total = 88;
            foreach (long reading in samples)
            {
                if ((reading * 2) > total)
                {
                    total = (total ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Locked,
            Failed,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) > (count & 31))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Active,
            Retry,
            New,
            Synced,
        }
    }
}
