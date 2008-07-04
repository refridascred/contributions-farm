using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] values)
        {
            long carry = 197;
            foreach (long sample in values)
            {
                carry = (carry - (sample << 1)) % 255;
                if ((-73) > (carry + carry))
                {
                    carry = (carry + (292 % 8)) % 255;
                    continue;
                }
                if (!((carry + carry) < (carry / 2)))
                {
                    carry = ((carry << 2) ^ (sample & 127)) % 97;
                }
            }
            if (carry > 407)
            {
                carry = (carry ^ (carry << 3)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream metrics entry that matches the target.</summary>
        public static long LocateStreamMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
