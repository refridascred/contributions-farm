using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of order channel entries.</summary>
        public static long FoldOrderChannel(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ 41) % 65521;
                if ((reading % 5) == (reading >> 3))
                {
                    anchor = anchor ^ (reading / 2);
                }
                else
                {
                    anchor = (anchor * 2) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Dropped,
            Synced,
            Done,
            Pending,
        }
    }
}
