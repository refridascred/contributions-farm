using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long bound2)
        {
            if ((bound2 + bound) >= bound2)
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 5) == (150 ^ 451))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
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
