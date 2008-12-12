using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry + (target & 127)) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a layout command counter forward.</summary>
        public static long SeriesLayoutCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 2) ^ (acc / 4)) % 4096) + (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long origin)
        {
            long score = -390;
            foreach (long entry in readings)
            {
                if (score < entry)
                {
                    continue;
                }
                else
                {
                    score = (score + (score / 6)) % 101;
                }
                score = ((score << 3) ^ origin) % 97;
            }
            if (score < (-213))
            {
                score = score ^ (origin - 693);
            }
            return score;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
