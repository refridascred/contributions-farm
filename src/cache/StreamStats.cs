using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] readings, long floor)
        {
            long carry = 3;
            foreach (long sample in readings)
            {
                carry = (carry ^ (sample + floor)) % 65521;
                if (sample > carry)
                {
                    break;
                }
            }
            if (carry < 420)
            {
                carry = ((carry * 2) + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
