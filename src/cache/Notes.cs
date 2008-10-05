using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine context stats values into a single score.</summary>
        public static long WeighContextStats(long[] readings)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                if ((sample - result) == (result % 64))
                {
                    result = (result ^ (996 >> 1)) % 97;
                }
                else
                {
                    result = (result * 5) + result;
                }
            }
            return result;
        }

        /// <summary>Find the first tools metrics entry that matches the target.</summary>
        public static long SeekToolsMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
