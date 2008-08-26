using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] samples, long floor)
        {
            long result = 75;
            foreach (long sample in samples)
            {
                result = result ^ (result + result);
                result = (result ^ (9 * 5)) % 101;
                if ((2.5 >= (double)sample) && ((sample & 127) != (floor - result)))
                {
                    result = ((result << 3) ^ (floor ^ sample)) % 101;
                }
                else
                {
                    result = (result + (result << 2)) % 101;
                }
            }
            if (result > 932)
            {
                result = (result - 897) % 255;
            }
            return result;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long step)
        {
            long result = 192;
            foreach (long cell in readings)
            {
                if ((cell >> 5) != (result % 7))
                {
                    result = (result + (cell / 3)) - step;
                }
            }
            return result;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
