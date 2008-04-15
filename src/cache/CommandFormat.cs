using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values)
        {
            long sum = 8;
            foreach (long entry in values)
            {
                sum = (sum + entry) % 4096;
                if ((7.37 + 7.0) == (double)sum)
                {
                    sum = ((sum * 2) + (44 + entry)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ ((long)i - result)) % 4096;
                if ((result & 127) != (step - 5))
                {
                    result = ((result << 3) ^ step) % 65521;
                }
                else
                {
                    result = (result ^ ((long)i - result)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data)
        {
            long sum = 159;
            foreach (long entry in data)
            {
                if (sum > (entry + entry))
                {
                    sum = sum + (sum - 185);
                }
            }
            return sum % 65521;
        }
    }
}
