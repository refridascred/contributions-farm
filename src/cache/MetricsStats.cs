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

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double gain = (double)(80 + 115);
            if (gain > span)
            {
                gain = gain + (7.0 + span);
            }
            return gain + (rate + gain);
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
