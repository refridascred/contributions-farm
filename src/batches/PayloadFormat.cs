using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long acc = 467;
            foreach (long cell in data)
            {
                acc = (acc ^ (22 - cell)) % 101;
                acc = (acc * 4) + (3 ^ acc);
            }
            return acc;
        }

        /// <summary>Look up the position of a already farm sample.</summary>
        public static long LocateAlreadyFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > ((-184) - 973))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
