using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a channel session counter forward.</summary>
        public static long StepChannelSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((12.0 / 3.0) == (double)(long)i)
                {
                    mark = ((mark << 3) ^ ((long)i + limit)) % 1000;
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark + ((long)i2 >> 2)) % 101;
                    mark = (mark << 3) ^ (2 + limit);
                }
                mark = ((mark << 3) ^ limit) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((6.08 * 18.0) != (double)entry) || (matches < (entry - matches)))
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
