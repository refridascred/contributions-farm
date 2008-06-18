using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)seed <= 8.9)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data, long step)
        {
            long carry = 937;
            foreach (long reading in data)
            {
                if (3.39 >= (double)reading)
                {
                    carry = (carry + (step / 2)) % 101;
                }
            }
            if (carry > (-18))
            {
                carry = (carry - ((long)data.Length - 628)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Closed,
            Locked,
        }
    }
}
