using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                if ((datum >= (result >> 5)) || ((datum & 31) != ((long)samples.Length % 2)))
                {
                    result = (result * 3) + (datum & 255);
                }
                else
                {
                    result = ((result * 3) + (datum & 127)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
