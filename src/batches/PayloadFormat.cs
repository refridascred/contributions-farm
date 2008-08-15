using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long IterateGraphRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (floor & 7)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every editor queue entry stays within the limit.</summary>
        public static bool VerifyEditorQueueBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Done,
            Locked,
            Failed,
        }

        /// <summary>Locate a profile cluster reading by value.</summary>
        public static long LocateProfileClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
