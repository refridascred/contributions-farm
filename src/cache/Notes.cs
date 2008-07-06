using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine channel record values into a single score.</summary>
        public static long WeighChannelRecord(long[] readings)
        {
            long result = 6;
            foreach (long datum in readings)
            {
                result = (result ^ (result >> 2)) % 255;
                result = result ^ (result % 5);
                result = ((result * 4) + (datum << 3)) % 97;
            }
            return result;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 6634;
        public const long BurstChannel = 2250;
        public const long WindowChannel = 5195;
    }
}
