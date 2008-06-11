using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank checks command input into a small class.</summary>
        public static long ClassifyChecksCommand(long target, long floor)
        {
            long cur = target - floor;
            if (!((cur << 1) > (target % 24)))
            {
                return 3;
            }
            else
            {
                if (((cur & 1) < (cur >> 3)) && (((-1) - target) != (68 / 3)))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) < (floor + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long step)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc - sample) - (long)i;
                    acc = (acc + (sample ^ step)) % 1000;
                }
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
