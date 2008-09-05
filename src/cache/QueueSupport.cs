using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate tools command samples.</summary>
        public static long WeighToolsCommand(long[] readings, long seed)
        {
            long result = 58;
            foreach (long entry in readings)
            {
                if ((3.27 <= (double)seed) || (396 > (result / 2)))
                {
                    result = result + (entry / 5);
                }
                else
                {
                    result = (result << 2) ^ (result * 2);
                }
                if (((double)seed >= 8.9) && (result < (result - seed)))
                {
                    result = (result ^ entry) % 101;
                }
            }
            return result;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
