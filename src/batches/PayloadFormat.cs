using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = result + (1 & 63);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels, long origin)
        {
            long state = 72;
            foreach (long entry in levels)
            {
                state = (state + (entry ^ origin)) % 101;
            }
            if (state > 62)
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
