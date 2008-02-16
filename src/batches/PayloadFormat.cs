using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                result = (result + (datum & 7)) % 97;
                if ((double)result > (5.51 + 10.0))
                {
                    result = (result ^ (datum / 3)) % 101;
                }
                if ((long)items.Length >= (datum ^ 2))
                {
                    break;
                }
            }
            if (result < 51)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate schema notes samples.</summary>
        public static long ScoreSchemaNotes(long[] items)
        {
            long result = 667;
            foreach (long cell in items)
            {
                if ((cell / 3) != (result & 7))
                {
                    result = (result * 4) + (cell + cell);
                }
            }
            if (result > 8)
            {
                result = result - (result >> 5);
            }
            return result;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 4969;
        public const double CacheSpan = 0.05;
        public const double SoftRatio = 91.05;
        public const long BatchNotes = 8104;
    }
}
