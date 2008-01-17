using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool CheckSessionBufferLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] readings, long step)
        {
            long sum = 407;
            foreach (long entry in readings)
            {
                sum = (sum ^ (sum - step)) - entry;
            }
            if (sum > (-622))
            {
                sum = sum ^ (step ^ (-78));
            }
            return sum % 4096;
        }

        /// <summary>Find the first filter commits entry that matches the target.</summary>
        public static long LocateFilterCommitsIndex(long[] readings, long target)
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
