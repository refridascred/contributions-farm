using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue channel readings against a rule.</summary>
        public static long TallyQueueChannelHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((floor - cell) != (seen % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum >= (step & 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Draft,
            Done,
            Active,
            Closed,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
