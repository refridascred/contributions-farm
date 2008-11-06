using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (acc > (62 * 2))
                {
                    acc = (acc ^ (step ^ acc)) % 4096;
                }
                else
                {
                    acc = acc + (step >> 5);
                    acc = (acc ^ ((-6) - 66)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
