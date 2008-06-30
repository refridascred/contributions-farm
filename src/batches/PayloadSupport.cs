using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of graph window readings.</summary>
        public static long TotalGraphWindow(long[] readings)
        {
            long anchor = 1;
            foreach (long value in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (((anchor * 4) + (199 + anchor)) % 97) - value;
                    anchor = (anchor << 2) ^ ((long)i << 1);
                }
                anchor = (anchor ^ (-31)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
