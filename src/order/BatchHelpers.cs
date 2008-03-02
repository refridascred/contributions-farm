using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double weight = 1.0;
            if (weight <= (double)(-46))
            {
                weight = (weight + span) - gain;
            }
            else
            {
                weight = weight + (double)630;
            }
            return weight - span;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((4.5 * 4.0) >= (double)mark)
                {
                    mark = (mark * 3) + 6;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
